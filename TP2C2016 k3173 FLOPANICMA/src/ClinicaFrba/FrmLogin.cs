using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;

namespace ClinicaFrba
{
    public partial class FrmLogin : Form
    {
        Usuario login;

        /*** PROCEDIMIENTOS ***/

        /// <summary>
        /// Punto de entrada del sistema
        /// Abre la ventana de login de usuario
        /// </summary>
        /// <param name="frm"></param>
        public FrmLogin(FrmMenu frm = null) // evita que se muestre el menu
        {
            // Intento cargar la fecha actual del login a partir de la fecha del archivo de configuracion
            DateTime fechaActual = new DateTime(); 
            try
            {
                fechaActual = Propiedades.getFechaActual;                
            }

            catch (Exception ex)
            {
                MessageBox.Show("La fecha configurada tiene un formato inválido: \n" + ex, "Login",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            if (frm != null)
            {                
                frm.Close();
            }

            /*
            // Finalmente, cargo la pantalla de login
             */ 
            InitializeComponent();
            txtClave.PasswordChar = '*';
            lbFechaActual.Text = fechaActual.ToString("dd-MM-yyyy");
        }

        /// <summary>
        /// Ejecución del login. 
        /// Se valida user - pass. 
        /// Se valida la cantidad de roles:
        ///     -Si tiene uno, se setea el mismo y se ingresa.
        ///     -Si tiene mas de uno, se carga una combobox para que el usuario seleccione uno
        ///     -Si no tiene ninguno, se le informa al usurio que debe contactarse con un administrador
        /// </summary>
        private void ejecutarLogin()
        {
            login = new Usuario(txtUsuario.Text, txtClave.Text);
            UsuarioDAO usuarioDao = new UsuarioDAO();
            Respuesta r = usuarioDao.credencialValida(login);

            if (r.CodigoError == 0)
            {
                login.Id = (int)r.ParametroAdicional;
                RolDAO rol = new RolDAO();
                r = rol.getRolesByUsername(login.Username);
                
                if (r.CodigoError > 0)
                {
                    MessageBox.Show(r.DescripcionError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    DataTable roles = r.Resultado;

                    if (roles.Rows.Count > 1)
                    {
                        cmbRoles.DataSource = roles;
                        btnSeleccionRol.Visible = true;
                        cmbRoles.DisplayMember = "DESCRIPCION";
                        cmbRoles.ValueMember = "ID_ROL";
                        cmbRoles.Visible = true;
                    }

                    else if (roles.Rows.Count == 1)
                    {
                        Rol unRol = new Rol(roles.Rows[0]);
                        login.Rol = unRol;
                        this.abrirFormularioMenu(login);
                    }
                        else
                        {
                             MessageBox.Show("El usuario no tiene perfiles asignados, conectactese con el administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }

            else
            {
                MessageBox.Show(r.DescripcionError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Abre el form menu, que contiene los menúes
        private void abrirFormularioMenu(Usuario usuario)
        {
            this.Hide();
            FrmMenu p = new FrmMenu(usuario, this);
            p.ShowDialog();
        }

        /*** EVENTOS ***/

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter) && String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter) && String.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClave.Focus();
            }

            else if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtClave.Focus();       
            }
        }

        // Permite ejecutar el login con un enter en el casillero de la pass
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && String.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ejecutarLogin();
            }
        }

        /*** BOTONES ***/

        // Se toma el rol seleccionado, y se le pregunta al usuario si quiere que ese pase a ser su único rol. 
        // En caso de que acepte, se eliminan los otros rol asociados.
        private void btnSeleccionRol_Click(object sender, EventArgs e)
        {
            Rol unRol = new Rol();
            unRol.Descripcion = cmbRoles.Text;
            unRol.Id = (int)cmbRoles.SelectedValue;

            DialogResult dialogResult = MessageBox.Show("Ha seleccionado el perfil " + cmbRoles.Text + " si continua ese perfil sera el que use desde ahora como unico perfil.", "Perfil permanente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RolDAO rolDao = new RolDAO();
                String perfiles = "";
                foreach (DataRowView rol in cmbRoles.Items)
                {
                    if ((int)rol.Row[0] != unRol.Id)
                    {
                        perfiles += (String)rol.Row[1] + " \n";
                        rolDao.eliminarRolInUsername(txtUsuario.Text, (String)rol.Row[1]);
                    }
                }
                MessageBox.Show("Desde ahora usara el rol seleccionado: " + unRol.Descripcion + "\n. Se eliminaron de su perfil los roles: " + perfiles);
                login.Rol = unRol;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            this.abrirFormularioMenu(login);
        }

        //Ejecuta la validacion de user y pass
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(String.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    ejecutarLogin();
                }
        }

        //Cierra la ventana de login
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
