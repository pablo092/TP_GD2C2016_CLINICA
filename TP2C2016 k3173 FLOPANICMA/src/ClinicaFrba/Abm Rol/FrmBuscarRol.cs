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
using System.Windows.Forms;
using ClinicaFrba.AdministradorDao;

namespace ClinicaFrba.ABM_Rol
{
    public partial class FrmBuscarRol : Form
    {
        public bool devolveValor { get; set; }
        public string valorDevuelto { get; set; }

        public FrmBuscarRol()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRol();
        }

        private void buscarRol()
        {
            Respuesta respuesta = null;
            listadoRoles.DataSource = null;

            if (listadoRoles.Columns.Count != 0)
            {
                listadoRoles.Columns.RemoveAt(0);
            }

            RolDAO rolDao = new RolDAO();
            respuesta = rolDao.getRolByDescripcion(txtRolNombre.Text);

            if (respuesta.CodigoError != 0)
            {
                msgBusqueda.Text = respuesta.DescripcionError;
                return;
            }

            if (respuesta.Resultado.Rows.Count > 0)
            {
                listadoRoles.DataSource = respuesta.Resultado;
                listadoRoles.Columns["ID_ROL"].Visible = false;
                listadoRoles.Columns["ACTIVO"].Visible = false;
                DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
                {
                    editar.HeaderText = "Acción";
                    editar.Text = "Editar";
                    editar.UseColumnTextForButtonValue = true;
                    editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    editar.FlatStyle = FlatStyle.Standard;
                    editar.CellTemplate.Style.BackColor = Color.Honeydew;
                    editar.DisplayIndex = 4;
                }
                listadoRoles.Columns.Add(editar);

                DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
                {
                    modificar.HeaderText = "Opción";
                    for(int i = 0; i < listadoRoles.Rows.Count; i++) {
                        if (!(bool)listadoRoles.Rows[i].Cells["ACTIVO"].Value)
                        {
                            modificar.Text = "Habilitar";
                        }
                        else
                        {
                            modificar.Text = "Deshabilitar";
                        }
                    }
                    modificar.UseColumnTextForButtonValue = true;
                    modificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    modificar.FlatStyle = FlatStyle.Standard;
                    modificar.CellTemplate.Style.BackColor = Color.Honeydew;
                    modificar.DisplayIndex = 4;
                }
                listadoRoles.Columns.Add(modificar);
                msgBusqueda.Text = "";

            }
            else
            {
                msgBusqueda.Text = "No se encontraron resultados";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            txtRolNombre.Text = "";
            msgBusqueda.Text = "";
            listadoRoles.DataSource = null;
            if (listadoRoles.Columns.Count != 0)
            {
                listadoRoles.Columns.RemoveAt(0);
            }
        }

        private void listadoRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = listadoRoles.Rows[e.RowIndex];
            Rol rol = new Rol();
                
            rol.Id = (int)filaSeleccionada.Cells["ID_ROL"].Value;
            rol.Descripcion = (String)listadoRoles.Rows[e.RowIndex].Cells["DESCRIPCION"].Value;
            rol.EstaHabilitado = (bool)listadoRoles.Rows[e.RowIndex].Cells["ACTIVO"].Value;

            if (e.ColumnIndex == 4)
            {
                if (rol.Equals(UsuarioLogueado.usuario.Rol))
                {
                    MessageBox.Show("No se puede deshabilitar el Rol con el que se ingresó al sistema.");
                    return;
                }
                else
                {
                    AdministradorRol admRol = new AdministradorRol();
                    admRol.modificarRol(rol);
                    listadoRoles.UpdateCellValue(e.ColumnIndex,e.RowIndex);
                }    
            }
            else
            {
                if (devolveValor)
                {
                    valorDevuelto = rol.Descripcion;
                }
                else
                {
                    FrmCrearRol frmModificarRol = new FrmCrearRol(rol);
                    frmModificarRol.ShowDialog();
                }
            }
            
        }
    }
}
