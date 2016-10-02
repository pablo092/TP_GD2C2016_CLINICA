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

namespace ClinicaFrba.ABM_Rol
{
    public partial class FrmBuscarRol : Form
    {
        public bool devolveValor { get; set; }
        public string valorDevuelto { get; set; }

        public FrmBuscarRol()
        {
            InitializeComponent();
            buscarRol();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarRol();
        }

        private void buscarRol()
        {
            listadoRoles.DataSource = null;
            if (listadoRoles.Columns.Count != 0)
            {
                listadoRoles.Columns.RemoveAt(0);
            }

            RolDAO rolDao = new RolDAO();

            Respuesta respuesta = rolDao.getRolByDescripcion(txtRolNombre.Text);
            if (respuesta.CodigoError != 0)
            {
                msgBusqueda.Text = respuesta.DescripcionError;
                return;
            }

            if (respuesta.Resultado.Rows.Count > 0)
            {
                listadoRoles.DataSource = respuesta.Resultado;
                listadoRoles.Columns["ID_ROL"].Visible = false;
                listadoRoles.Columns["ID_ESTADO"].Visible = false;
                DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
                {
                    buttons.HeaderText = "Acción";
                    buttons.Text = "Editar";
                    buttons.UseColumnTextForButtonValue = true;
                    buttons.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    buttons.FlatStyle = FlatStyle.Standard;
                    buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                    buttons.DisplayIndex = 4;
                }
                listadoRoles.Columns.Add(buttons);
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
            Rol rol = new Rol();
            DataGridViewRow filaSeleccionada = listadoRoles.Rows[e.RowIndex];

            rol.Id = (int)filaSeleccionada.Cells["ID_ROL"].Value;
            rol.Descripcion = (String)listadoRoles.Rows[e.RowIndex].Cells["DESCRIPCION"].Value;
            rol.EstaHabilitado = (int)listadoRoles.Rows[e.RowIndex].Cells["ID_ESTADO"].Value == 1;
            
            if (devolveValor)
            {
                valorDevuelto = rol.Descripcion;
            }
            else
            {
                FrmCrearRol frmModificarRol = new FrmCrearRol(rol);
                frmModificarRol.ShowDialog();
            }
            buscarRol();
        }
        


    }
}
