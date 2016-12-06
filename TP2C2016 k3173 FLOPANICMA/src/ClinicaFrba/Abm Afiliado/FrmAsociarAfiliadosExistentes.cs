using ClinicaFrba.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class FrmAsociarAfiliadosExistentes : Form
    {
        public FrmAsociarAfiliadosExistentes()
        {
            InitializeComponent();
        }


        /*** EVENTOS ***/

        private void txtPricipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtVinculado.Focus();
            }
        }

        /*** BOTONES ***/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtPricipal.Text)) || (string.IsNullOrWhiteSpace(txtVinculado.Text)))
            {
                MessageBox.Show("Debe introducir los dos numeros de documento", "Vincular Afiliados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int nroAfiliadoPrincipal = new AfiliadoDAO().GetNroAfiliadoPorDocumento(Convert.ToDecimal(txtPricipal.Text));

                if (nroAfiliadoPrincipal == -1)
                {
                    MessageBox.Show("El numero de documento del afiliado principal no existe", "Vincular afiliados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int idVinculado = new AfiliadoDAO().GetIdPorDocumento(Convert.ToDecimal(txtVinculado.Text));

                    if (idVinculado == -1)
                    {
                        MessageBox.Show("El numero de documento del afiliado a vincular no existe", "Vincular afiliados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (new AfiliadoDAO().EstaVinculado(txtPricipal.Text, txtVinculado.Text))
                        {
                            MessageBox.Show("Los afiliados ingresados ya pertenecen al mismo grupo familiar", "Vincular afiliados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int nroAfiliadoNuevo = new AfiliadoDAO().UltimoAfiliado(nroAfiliadoPrincipal);
                            new AfiliadoDAO().AgruparFamiliares(nroAfiliadoNuevo, idVinculado);
                            txtNroAfiliado.Text = Convert.ToString(nroAfiliadoNuevo);
                        }
                    }
                }
            }
        }


    }
}
