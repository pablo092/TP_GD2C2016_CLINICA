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
using ClinicaFrba.ABM_Rol;

namespace ClinicaFrba.ABM_Rol
{
    public partial class FrmBuscarRol : Form
    {
        public bool devolveValor { get; set; }
        public string valorDevuelto { get; set; }

        /*** INICIALIZACIONES ***/
        public FrmBuscarRol()
        {
            InitializeComponent();
        }

        /*** PROCESOS ***/
        private void buscarRol()
        {
            Respuesta respuesta = null;
            listadoRoles.DataSource = null;

            if (listadoRoles.Columns.Count != 0)
            {
                listadoRoles.Columns.Clear();
            }

            RolDAO rolDao = new RolDAO();
            respuesta = rolDao.getRolByDescripcion(txtRolNombre.Text);

            if (respuesta.Resultado.Rows.Count > 0)
            {
                // vincula la fuente de datos (datatable) con el datagridview listadoRoles
                BindingSource SBind = new BindingSource();
                SBind.DataSource = respuesta.Resultado;
                this.listadoRoles.AutoGenerateColumns = true;
                this.listadoRoles.DataSource = SBind;

                listadoRoles.Columns["ID_ROL"].Visible = false;
                listadoRoles.Columns["ACTIVO"].Visible = false;
                listadoRoles.SelectedRows[0].Selected = false; // evita que se ubique el foco en la primera fila todo el tiempo
                
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
                modificar.Name = "columnaModificar"; 
                {
                    modificar.HeaderText = "                Opción";
                    modificar.AutoSizeMode = modificar.AutoSizeMode;
                    modificar.CellTemplate.Style.BackColor = Color.Honeydew;
                    modificar.DisplayIndex = 4;
                    listadoRoles.Columns.Add(modificar); // inserto la columna de botones en la ultima posicion (4)
                    listadoRoles.Columns[4].Visible = true;

                    for (int i = 0; i < listadoRoles.Rows.Count; i++)
                    {
                        // si el rol esta activo le ofrece deshabilitarlo, caso contrario que lo habilite
                        if ((bool)listadoRoles.Rows[i].Cells["ACTIVO"].Value)
                        {
                            DataGridViewButtonCell btnModificar = new DataGridViewButtonCell();
                            btnModificar.Value = "Deshabilitar rol";
                            listadoRoles.Rows[i].Cells[4] = btnModificar;
                        }
                        else
                        {
                            DataGridViewButtonCell btnModificar = new DataGridViewButtonCell();
                            btnModificar.Value = "Habilitar rol";
                            listadoRoles.Rows[i].Cells[4] = btnModificar;
                        }
                    }
                }
                msgBusqueda.Text = "";
            }
            else
            {
                msgBusqueda.Text = "No se encontraron resultados";
            }
        }

        private void limpiarListadoRoles()
        {
            listadoRoles.Columns.Clear();
        }

        /*** EVENTOS ***/
        private void listadoRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // si seleccione alguna fila del listado
            {
                DataGridViewRow filaSeleccionada = listadoRoles.Rows[e.RowIndex];
                Rol rol = new Rol();

                rol.Id = (int)filaSeleccionada.Cells["ID_ROL"].Value;
                rol.Descripcion = (String)listadoRoles.Rows[e.RowIndex].Cells["DESCRIPCION"].Value;
                rol.EstaHabilitado = (bool)listadoRoles.Rows[e.RowIndex].Cells["ACTIVO"].Value;

                System.Console.WriteLine("ID_ROL: " + rol.Id +" DESCRIPCION: " + rol.Descripcion + " ACTIVO: " + rol.EstaHabilitado);

                if (e.ColumnIndex == 4)
                {
                    if (rol.Id.Equals(UsuarioLogueado.usuario.Rol.Id))
                    {
                        MessageBox.Show("No se puede deshabilitar el Rol con el que se ingresó al sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        AdministradorRol admRol = new AdministradorRol();
                        admRol.modificarRol(rol);
                        listadoRoles.UpdateCellValue(e.ColumnIndex, e.RowIndex);
                        limpiarListadoRoles();
                        buscarRol();
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
                        limpiarListadoRoles();
                        buscarRol();
                    }
                }
            }   
        }

        /*** BOTONES ***/
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarListadoRoles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarListadoRoles();
            buscarRol();
        }
    }
}
