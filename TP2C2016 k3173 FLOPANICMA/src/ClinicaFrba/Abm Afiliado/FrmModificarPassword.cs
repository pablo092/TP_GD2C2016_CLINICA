using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.ABM_Rol;
using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;

namespace ClinicaFrba.ABM_Afiliado
{
    public partial class FrmModificarPassword : Form
    {
        private Usuario usuario = new Usuario();
       
        public FrmModificarPassword(Usuario usr = null)
        {
            InitializeComponent();
            txtPasswordActual.PasswordChar = '*';
            txtPasswordNueva.PasswordChar = '*';
            txtPasswordConfirmacionNueva.PasswordChar = '*';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtPasswordActual.Text = txtPasswordActual.Text.Trim();

            if (txtPasswordActual.Text.Equals("") || 
                txtPasswordNueva.Text.Trim().Equals("") || 
                txtPasswordConfirmacionNueva.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos. No se admiten contraseñas que sólo contengan espacios.");
                return;
            }

            if (!txtPasswordNueva.Text.Equals(txtPasswordConfirmacionNueva.Text)) {
                MessageBox.Show("Las contraseñas ingresadas no coinciden.");
                return;
            }

            Boolean passValida = new UsuarioDAO().passwordValida(txtPasswordActual.Text);
            if (!passValida)
            {
                MessageBox.Show("La contraseña actual ingresada es incorrecta.");
                return;
            }

            new UsuarioDAO().actualizarPassword(txtPasswordConfirmacionNueva.Text);

            MessageBox.Show("Contraseña modificada correctamente.");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
