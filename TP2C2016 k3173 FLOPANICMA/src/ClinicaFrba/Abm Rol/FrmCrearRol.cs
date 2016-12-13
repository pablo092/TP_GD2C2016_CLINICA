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
using ClinicaFrba.ABM_Rol;
using System.Windows.Forms;

namespace ClinicaFrba.ABM_Rol
{
    public partial class FrmCrearRol : Form
    {
        Rol rol = new Rol();

        /*** INICIALIZACIONES ***/

        // constructor usado al querer insertar un nuevo rol
        public FrmCrearRol()
        {
            InitializeComponent();
            traerFuncionalidades();
        }

        // constructor usado al querer modificar nuevo rol ya existente
        public FrmCrearRol(Rol r)
        {
            InitializeComponent();
            this.Text = "EDITAR ROL";
            btnLimpiar.Text = "Deshacer";
            rol = r;
            txtRolNombre.Text = rol.Descripcion;                    
            traerFuncionalidadesByRol(rol.Descripcion);

            if (r.Equals(UsuarioLogueado.usuario.Rol)) 
            {
                MessageBox.Show("No se permite modificar el Rol con el que se ingresó al sistema.","Modificar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLimpiar.Enabled = false;
                btnAgregar.Enabled = false;
                txtRolNombre.Enabled = false;
                checkFuncionalidades.SelectionMode = SelectionMode.None;
            }
        }

        /*** PROCEDIMIENTOS ***/
        private void traerFuncionalidades()
        {
            FuncionalidadDAO funcionalidadDAO = new FuncionalidadDAO();

            DataTable dt = funcionalidadDAO.getFuncionalidades();

            checkFuncionalidades.DataSource = dt;
            checkFuncionalidades.DisplayMember = "DESCRIPCION";
        }

        private void limpiarFormulario()
        {
            txtRolNombre.Text = "";

            foreach (int seleccionado in checkFuncionalidades.CheckedIndices)
            {
                checkFuncionalidades.SetItemChecked(seleccionado, false);
            }
            if (rol.Id > 0)
            {
                txtRolNombre.Text = rol.Descripcion;
                traerFuncionalidadesByRol(rol.Descripcion);
            }
        }

        private void traerFuncionalidadesByRol(String descripcionRol)
        {
            FuncionalidadDAO funcionalidadDAO = new FuncionalidadDAO();

            Respuesta resultadoSP = funcionalidadDAO.getFuncionalidadesByRol(txtRolNombre.Text);

            traerFuncionalidades();

            int cantFunc = (int)resultadoSP.Resultado.Rows.Count;

            int indice;

            for (int i = 0; i < cantFunc; i++)
            {
                indice = (int)resultadoSP.Resultado.Rows[i][0];

                checkFuncionalidades.SetItemChecked(indice - 1, true);
            }
        }

        /*** VALIDACIONES ***/
        // solo permite ingresar caracteres del alfabeto y BACKSPACE
        private void txtRolNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            /* 
               Los numeros de los primeros dos argumentos son caracteres del abecedario en la tabla ASCII.
               El numero 8 representa al BACKSPACE en el codigo ASCII
            */
            if (!(caracter >= 65 && caracter <= 90) && !(caracter >= 97 && caracter <= 122) && (!char.IsSeparator(caracter)) && (caracter != 8))
            {
                e.Handled = true;
            }
        }

        /*** EVENTOS ***/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Respuesta resultadoSP = new Respuesta();

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataRowView item in checkFuncionalidades.CheckedItems)
            {
                funcionalidades.Add(new Funcionalidad(item));
            }

            rol.Descripcion = txtRolNombre.Text.Trim();

            RolDAO rolDAO = new RolDAO();

            if (this.Text == "INGRESAR ROL")
            {
                resultadoSP = rolDAO.insertarRol(rol);
                
                if(resultadoSP.CodigoError == 1)
                {
                    msgCreacion.Text = resultadoSP.DescripcionError; // si hubo un error al crear un nuevo rol (codigoError == 1), muestra el mensaje de error en el toolStrip
                }
                else
                {
                    foreach(Funcionalidad funcionalidad in funcionalidades)
                    {
                        resultadoSP = rolDAO.insertaFuncionalidadEnRol(rol,funcionalidad);
                    }

                    if (resultadoSP.CodigoError == 1) // si hubo error al insertar alguna de las funcionalidades (codigoError == 1), muestra el mensaje de error en el toolStrip. Sino todo ok
                    {
                        msgCreacion.Text = resultadoSP.DescripcionError;
                    }
                    else
                    {
                        foreach (Funcionalidad funcionalidad in funcionalidades)
                        {
                            resultadoSP = rolDAO.insertaFuncionalidadEnRol(rol, funcionalidad);
                        }

                        MessageBox.Show("El rol " + rol.Descripcion + " se ha guardado correctamente", "Insertar rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            if( (this.Text == "EDITAR ROL") )
            {
                rolDAO.limpiarFuncionalidades(rol.Id);
                
                foreach (Funcionalidad funcionalidad in funcionalidades)
                {
                    resultadoSP = rolDAO.insertaFuncionalidadEnRol(rol, funcionalidad);
                }

                if(txtRolNombre.Modified)
                {
                    rolDAO.updateRol(rol);
                }

                MessageBox.Show("El rol " + rol.Descripcion + " se ha guardado correctamente", "Modificar rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }
    }
}
