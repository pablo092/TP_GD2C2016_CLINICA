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

        /// <summary>
        /// Punto de entrada del sistema
        /// Abre la ventana de login de usuario
        /// </summary>
        /// <param name="frm"></param>
        public FrmLogin(FrmMenu frm = null )
        {
            /*
             * Intento cargar la fecha actual a partir del archivo de configuracion
             */
            DateTime fechaActual = new DateTime(); 
            try
            {
                fechaActual = Propiedades.getFechaActual;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("La fecha configurada tiene un formato inválido: \n" + ex);
            }            

            if (frm != null)
            {                
                frm.Close();
            }

            /*
             * Busco todas las publicaciones vencidas, y actualizo su estado a finalizada. 
             * El trigger en la tabla publicación se encargará de generar la venta y facturación. 
             * Se agrega un waitCursor por si la operación demora mucho tiempo.
             */
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                new LoginDAO().actualizarPublicacionesFinalizadas();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            /*
             * Finalmente, cargo la pantalla de login
             */
            InitializeComponent();
            txtClave.PasswordChar = '*';
            lbFechaActual.Text = fechaActual.ToString("dd-MM-yyyy");
        }
       
        /// <summary>
        /// Ejecuta la validacion de user y pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ejecutarLogin();
        }

        /// <summary>
        /// Ejecución del login. 
        /// Se valida user - pass. 
        /// Se valida la cantidad de roles:
        ///     -Si tiene uno, se setea el mismo y se ingresa.
        ///     -Si tiene mas de uno, se carga una combo para que el usuario seleccione uno
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
                    MessageBox.Show(r.DescripcionError);
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
                        MessageBox.Show("El usuario no tiene perfiles asignados, conectactese con el administrador");
                    }
                }
            }
            else
            {
                MessageBox.Show(r.DescripcionError);
            }
        }

        /// <summary>
        /// Cierra la ventana de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Se toma el rol seleccionado, y se le pregunta al usuario si quiere que ese pase a ser su único rol. 
        /// En caso de que acepte, se eliminan los otros rol asociados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Abre el form menu, que contiene los menúes
        /// </summary>
        /// <param name="usuario"></param>
        private void abrirFormularioMenu(Usuario usuario)
        {
            this.Hide();
            FrmMenu p = new FrmMenu(usuario, this);
            p.ShowDialog();

        }

        /// <summary>
        /// Permite ejecutr el login con un enter en el casillero de la pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ejecutarLogin();
            }
        }

    }
}
