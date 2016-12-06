using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class FrmComprarBono : Form
    {
        /*** INICIALIZACIONES ***/
        public FrmComprarBono()
        {
            InitializeComponent();
        }
		
		private void FrmComprarBono_Load(object sender, EventArgs e)
        {
            String descRol = UsuarioLogueado.usuario.Rol.Descripcion;

            if (descRol == "AFILIADO")
            {
                lblNumeroAfiliado.Hide();
                tbNumeroAfiliado.Hide();
                lblAfilado.Show();

                AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                int nroAfiliado = afiliadoDAO.GetNroAfiliadoPorUsuario(UsuarioLogueado.usuario.Id);
                Decimal costoBonoConsulta = afiliadoDAO.GetCostoBonoConsulta(nroAfiliado);

                tbImporteTotal.Text = (costoBonoConsulta * numCantidadBonos.Value).ToString();
                
                numCantidadBonos.Enabled = true;
            }
        }

        /*** VALIDACIONES ***/
		//restringe el ingreso de caracteres al textbox, permitiendo solamente numeros enteros y BACKSPACE
        private void tbNumeroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if( (!char.IsDigit(caracter)) && (caracter != 8) ) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }
        }

        // muestra el errorProvider con su mensaje
        private void tbNumeroAfiliado_Validated(object sender, EventArgs e)
        {
            String nroAfiliado = tbNumeroAfiliado.Text;

            if ( ( !String.IsNullOrEmpty(nroAfiliado) ) && ( !AfiliadoExistente(Convert.ToInt32(nroAfiliado)) ) )
            {
                epNroAfiliadoNull.SetError(tbNumeroAfiliado, "El numero de usuario no es valido o esta inactivo");
            }
            else
            {
                epNroAfiliadoNull.Clear();
            }
        }

        // devuelve 1 si el afiliado existe en la base con ese nro, devuelve 0 en caso contrario
        private bool AfiliadoExistente(int nroAfiliado)
        {
            AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
            return afiliadoDAO.AfiliadoExistente(nroAfiliado);
        }

        /*** PROCEDIMIENTOS ***/
        // si se logueo como administrador o administrativo
        private void RegistrarCompraBono()
        {
            CompraBonoDAO compraBonoDAO = new CompraBonoDAO();

            // cargo el DTO compra bono
            CompraBono compraBono = new CompraBono();
            compraBono.NroAfiliado = Convert.ToInt32(tbNumeroAfiliado.Text);
            compraBono.CantidadBonos = (int) numCantidadBonos.Value;

            compraBonoDAO.InsertarCompraBono(compraBono); // el DAO inserta una nueva compra de bono
        }

        // si se logueo como afiliado
        private void RegistrarCompraBono(int nroAfiliado)
        {
            CompraBonoDAO compraBonoDAO = new CompraBonoDAO();

            // cargo el DTO compra bono
            CompraBono compraBono = new CompraBono();
            compraBono.NroAfiliado = nroAfiliado;
            compraBono.CantidadBonos = (int)numCantidadBonos.Value;

            compraBonoDAO.InsertarCompraBono(compraBono); // el DAO inserta una nueva compra de bono
        }

        /*** EVENTOS ***/
        private void tbNumeroAfiliado_TextChanged(object sender, EventArgs e)
        {
            tbImporteTotal.Clear();
            
            if (!String.IsNullOrEmpty(tbNumeroAfiliado.Text))
            {
                Int32 nroAfiliado = Convert.ToInt32(tbNumeroAfiliado.Text);

                if (AfiliadoExistente(nroAfiliado))
                {
                    AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                    Decimal costoBonoConsulta = afiliadoDAO.GetCostoBonoConsulta(nroAfiliado);

                    tbImporteTotal.Text = (costoBonoConsulta * numCantidadBonos.Value).ToString();
                }
            }

            numCantidadBonos.Enabled = true;
        }
        
        private void numCantidadBonos_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNumeroAfiliado.Text))
            {
                Int32 nroAfiliado = Convert.ToInt32(tbNumeroAfiliado.Text);

                if (AfiliadoExistente(nroAfiliado))
                {
                    AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                    Decimal costoBonoConsulta = afiliadoDAO.GetCostoBonoConsulta(nroAfiliado);

                    tbImporteTotal.Text = (costoBonoConsulta * numCantidadBonos.Value).ToString();
                }
            }

            else
            {
                AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                int nroAfiliado = afiliadoDAO.GetNroAfiliadoPorUsuario(UsuarioLogueado.usuario.Id);
                Decimal costoBonoConsulta = afiliadoDAO.GetCostoBonoConsulta(nroAfiliado);

                tbImporteTotal.Text = (costoBonoConsulta * numCantidadBonos.Value).ToString();
            }
        }

        /*** BOTONES ***/
		private void btnComprar_Click(object sender, EventArgs e)
        {
            if(UsuarioLogueado.usuario.Rol.Descripcion == "AFILIADO")
            {
                AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                int nroAfiliado = afiliadoDAO.GetNroAfiliadoPorUsuario(UsuarioLogueado.usuario.Id);

                RegistrarCompraBono(nroAfiliado);
                MessageBox.Show("Su compra se ha realizado exitosamente.", "Compra de bonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                if (tbNumeroAfiliado.Text.Trim() == "")
                {
                    MessageBox.Show("Debe introducir un numero de afiliado.", "Compra de bonos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
                else if ( !AfiliadoExistente(Convert.ToInt32(tbNumeroAfiliado.Text)) ) 
                {
                    MessageBox.Show("No existe un afiliado con el numero ingresado o no se encuentra activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    else
                    {
                        RegistrarCompraBono();
                        MessageBox.Show("Su compra se ha realizado exitosamente.", "Compra de bonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
            }
        }
		
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
