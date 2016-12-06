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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class frmPedidoTurno : Form
    {
        /*** INICIALIZACIONES ***/

        public frmPedidoTurno()
        {
            InitializeComponent();
        }

        private void FrmPedidoTurno_Load(object sender, EventArgs e)
        {
            LoadEspecialidades();
        }

        private void LoadEspecialidades()
        {
            EspecialidadMedicaDAO especialidadMedicaDAO = new EspecialidadMedicaDAO(); 
            DataTable dt = especialidadMedicaDAO.GetAllEspecialidades();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // uso constructor con parametros
                EspecialidadMedica especialidadMedica = 
                    new EspecialidadMedica( (Decimal)dt.Rows[i][0], (Decimal)dt.Rows[i][1], (String)dt.Rows[i][2] );

                cmbEspecialidad.Items.Add(especialidadMedica.Detalle);
            }
        }

        private void LoadProfesionalesPorEspecialidad()
        {
            ProfesionalDAO profesionalDAO = new ProfesionalDAO();
            DataTable dt = profesionalDAO.GetProfesionalesPorEspecialidad( (string)cmbEspecialidad.SelectedItem );

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Profesional profesional = new Profesional();
                profesional.Id = (int)dt.Rows[i][0];
                profesional.Nombre = (string)dt.Rows[i][1];
                profesional.Apellido = (string)dt.Rows[i][2];
                profesional.Matricula = (int)dt.Rows[i][3];

                cmbProfesional.Items.Add(profesional.Matricula + " - " + profesional.Apellido + ", " + profesional.Nombre);
            }
        }

        private void LoadFechasDisponiblesProfesional()
        {
            ProfesionalDAO profesionalDAO = new ProfesionalDAO();

            int longSubstring = cmbProfesional.Text.IndexOf("-");
            String matriculaProfesional = cmbProfesional.SelectedItem.ToString().Substring(0, longSubstring);

            DataTable dt = profesionalDAO.GetFechasDisponiblesPorProfesional( Convert.ToInt32(matriculaProfesional) );

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("El profesional no tiene fechas disponibles.", "Pedido de turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAsignarTurno.Enabled = false;
            }

            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbFechasDisponibles.Items.Add( Convert.ToString(dt.Rows[i][0]) );
                }
                cmbFechasDisponibles.Enabled = true;
            }
        }

        /*** PROCEDIMIENTOS ***/

        private void registrarPedidoTurno()
        {
            PedidoTurnoDAO pedidoTurnoDAO = new PedidoTurnoDAO();

            // obtengo la matricula del profesional seleccionado en el combobox
            int longSubstring = cmbProfesional.Text.IndexOf("-");
            String matriculaProfesional = cmbProfesional.Text.Substring(0, longSubstring);

            // cargo el pedido de turno
            PedidoTurno pedidoTurno = new PedidoTurno();
            pedidoTurno.Fecha = Convert.ToDateTime(cmbFechasDisponibles.SelectedItem);
            pedidoTurno.MatriculaProfesional = Convert.ToInt32(matriculaProfesional);
            pedidoTurno.IdAfiliado = Convert.ToInt32(tbNumeroAfiliado.Text);
            pedidoTurno.IdEspecialidad = pedidoTurnoDAO.GetIdEspecialidad(cmbEspecialidad.Text);

            if (new AfiliadoDAO().TurnoReservado(pedidoTurno.Fecha,pedidoTurno.IdAfiliado))
            {
                MessageBox.Show("El afiliado ya tiene un turno asignado en la fecha seleccionada. Elija una fecha distinta", "Pedido de turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pedidoTurnoDAO.InsertarPedidoTurno(pedidoTurno);// inserto un nuevo pedido de turno
                MessageBox.Show("Su pedido de turno se ha registrado correctamente.", "Pedido de turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        /*** EVENTOS ***/

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProfesional.Items.Clear();
            LoadProfesionalesPorEspecialidad();
            cmbProfesional.Enabled = true;
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFechasDisponibles.Items.Clear();
            LoadFechasDisponiblesProfesional();
        }

        private void cmbFechasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAsignarTurno.Enabled = true;
        }


        /*** VALIDACIONES ***/
        // restringe el ingreso de caracteres que no sean digitos o BACKSPACE
        private void tbNumeroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!Char.IsDigit(caracter) && (caracter != 8)) // 8: hexadecimal que representa el BACKSPACE en ASCII
            {
                e.Handled = true;
            }
        }

        // muestra el errorProvider con su mensaje
        private void tbNumeroAfiliado_Validated(object sender, EventArgs e)
        {
            if (tbNumeroAfiliado.Text.Trim() == "")
            {
                epNroAfiliadoNull.SetError(tbNumeroAfiliado, "Debe introducir un numero de afiliado");
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


        /*** BOTONES ***/
        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            if (tbNumeroAfiliado.Text.Trim() == "")
            {
                MessageBox.Show("Debe introducir un numero de afiliado.", "Pedido de turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if( !AfiliadoExistente(Convert.ToInt32(tbNumeroAfiliado.Text)) )
            {
                MessageBox.Show("No existe un afiliado con el numero ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    registrarPedidoTurno();
                }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
