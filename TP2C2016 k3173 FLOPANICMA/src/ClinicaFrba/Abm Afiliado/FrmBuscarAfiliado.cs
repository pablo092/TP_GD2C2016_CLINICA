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
using ClinicaFrba.Abm_Afiliado;

namespace ClinicaFrba.ABM_Afiliado
{
    public partial class FrmBuscarAfiliado : Form
    {
        public bool devolveValor { get; set; }
        public string valorDevuelto { get; set; }

        public FrmBuscarAfiliado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarAfiliado();
        }

        private void buscarAfiliado()
        {
            Respuesta respuesta = null;
            listadoAfiliados.DataSource = null;

            if (listadoAfiliados.Columns.Count != 0)
            {
                listadoAfiliados.Columns.RemoveAt(0);
            }

            AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
            respuesta = afiliadoDAO.getAfiliadoByDescripcion(txtAfilNombre.Text);

            if (respuesta.CodigoError != 0)
            {
                msgBusqueda.Text = respuesta.DescripcionError;
                return;
            }

            if (respuesta.Resultado.Rows.Count > 0)
            {
                listadoAfiliados.DataSource = respuesta.Resultado;
                listadoAfiliados.Columns["NUMERO_AFILIADO"].Visible = false;
                listadoAfiliados.Columns["ACTIVO"].Visible = false;
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
                listadoAfiliados.Columns.Add(editar);

                DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
                {
                    modificar.HeaderText = "Opción";
                    for(int i = 0; i < listadoAfiliados.Rows.Count; i++) {
                        if (!(bool)listadoAfiliados.Rows[i].Cells["ACTIVO"].Value)
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
                listadoAfiliados.Columns.Add(modificar);
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
            txtAfilNombre.Text = "";
            msgBusqueda.Text = "";
            listadoAfiliados.DataSource = null;
            if (listadoAfiliados.Columns.Count != 0)
            {
                listadoAfiliados.Columns.RemoveAt(0);
                listadoAfiliados.Columns.RemoveAt(1);
            }
        }

        private void listadoAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = listadoAfiliados.Rows[e.RowIndex];
            Afiliado afiliado = new Afiliado();

            afiliado.NroAfiliado = (string)filaSeleccionada.Cells["NUMERO_AFILIADO"].Value;
            afiliado.Nombre = (String)listadoAfiliados.Rows[e.RowIndex].Cells["NOMBRE"].Value;
            afiliado.NumeroDocumento = (string)listadoAfiliados.Rows[e.RowIndex].Cells["NUMERO_DOCUMENTO"].Value;

            if (e.ColumnIndex == 4)
            {
                if (afiliado.Equals(UsuarioLogueado.usuario.Rol))
                {
                    MessageBox.Show("No se puede deshabilitar el Rol con el que se ingresó al sistema.");
                    return;
                }
                else
                {
                    AdministradorAfiliado admAfil = new AdministradorAfiliado();
                    admAfil.modificarAfiliado(afiliado);
                    listadoAfiliados.UpdateCellValue(e.ColumnIndex, e.RowIndex);
                }    
            }
            else
            {
                if (devolveValor)
                {
                    valorDevuelto = afiliado.NroAfiliado;
                }
                else
                {
                    FrmCrearAfiliado frmModificarAfil = new FrmCrearAfiliado(afiliado);
                    frmModificarAfil.ShowDialog();
                }
            }

        }
    }
}
