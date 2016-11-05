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

namespace ClinicaFrba.Listado_Estadistico
{
    public partial class FrmListadoEstadistico : Form
    {

        public FrmListadoEstadistico()
        {
            InitializeComponent();

            //carga ListadoMetodos
            cbListaMetodos.DataSource = ListadoEstadisticoDAO.getMetodosFiltro();
            cbListaMetodos.DisplayMember = "Value";
            cbListaMetodos.ValueMember = "Key";
            cbListaMetodos.DropDownStyle = ComboBoxStyle.DropDownList;

            //Carga Trimestres
            //TrimestreDAO trimestreDao = new TrimestreDAO();
            //cbTrimestres.DataSource = trimestreDao.getAll();
            cbTrimestres.DisplayMember = "Periodo";
            cbTrimestres.ValueMember = "Id";
            cbTrimestres.DropDownStyle = ComboBoxStyle.DropDownList;

            //Carga Rubros
            //RubroDAO rubroDao = new RubroDAO();
            //Respuesta respuestaRubros = rubroDao.getAll();
            //if (respuestaRubros.CodigoError != 0)
            //{
            //    msgUsuario.Text = respuestaRubros.DescripcionError;
            //    return;
            //}
            //cbRubros.DataSource = respuestaRubros.Resultado;
            cbRubros.DisplayMember = "DESCRIPCION_CORTA";
            cbRubros.ValueMember = "ID_RUBRO";
            cbRubros.Enabled = false;
            cbRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            

            //Carga Visibilidades
            //VisibilidadDAO visibilidadDao = new VisibilidadDAO();
            //Respuesta respuestaVisibilidades = visibilidadDao.getAll();
            //if (respuestaVisibilidades.CodigoError != 0)
            //{
            //    msgUsuario.Text = respuestaVisibilidades.DescripcionError;
            //    return;
            //}
            //cbVisibilidades.DataSource = respuestaVisibilidades.Resultado;
            cbVisibilidades.DisplayMember = "DESCRIPCION";
            cbVisibilidades.ValueMember = "ID_VISIBILIDAD";
            cbVisibilidades.Enabled = false;
            cbVisibilidades.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbListaMetodos.SelectedItem = null;
            cbVisibilidades.SelectedItem = null;
            cbRubros.SelectedItem = null;
            cbTrimestres.SelectedItem = null;
        }

        private void CbListaMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRubros.Enabled = false;
            cbVisibilidades.Enabled = false;

            ComboBox cmb = (ComboBox)sender;

            if (cmb.SelectedItem == null) {
                return;
            }

            ListadoEstadisticoDAO.Metodo selectedItem = ((KeyValuePair<ListadoEstadisticoDAO.Metodo, String>)cmb.SelectedItem).Key;

            if (ListadoEstadisticoDAO.Metodo.ProductosCompradosPorRubro.Equals(selectedItem))
            {
                cbRubros.Enabled = true;
            }
            else if (ListadoEstadisticoDAO.Metodo.ProductosNoVendidosPorVisibilidad.Equals(selectedItem))
            {
                cbVisibilidades.Enabled = true;
            }
            

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            msgUsuario.Text = "";
            listado.DataSource = null;
            if (cbListaMetodos.SelectedItem == null)
            {
                msgUsuario.Text = "Debe seleccionar un método de Búsqueda";
                return;
            }
            if (tbAnio.Text.Equals(""))
            {
                msgUsuario.Text = "Debe ingresar un año";
                return;
            } 
            if (cbTrimestres.SelectedItem == null)
            {
                msgUsuario.Text = "Debe seleccionar un Trimestre";
                return;
            }

            ListadoEstadisticoDAO.Metodo metodo = ((KeyValuePair<ListadoEstadisticoDAO.Metodo, String>)cbListaMetodos.SelectedItem).Key;

            //Trimestre trimestre = (Trimestre)cbTrimestres.SelectedItem;

            int anio = Int32.Parse(tbAnio.Text);

            if (anio < 1900 || anio > 2300) {
                msgUsuario.Text = anio + " no es un año válido";
            }

            ListadoEstadisticoDAO dao = new ListadoEstadisticoDAO();

            Respuesta respuesta = null;

            if (metodo.Equals(ListadoEstadisticoDAO.Metodo.FacturasPorVendedor))
            {
                //respuesta = dao.getTop5FacturasPorVendedor(anio, trimestre);                
            }
            else if (metodo.Equals(ListadoEstadisticoDAO.Metodo.MontoPorVendedor))
            {
                //respuesta = dao.getTop5MontoFacturasPorVendedor(anio, trimestre);
            }
            else if (metodo.Equals(ListadoEstadisticoDAO.Metodo.ProductosCompradosPorRubro))
            {
                if (cbRubros.SelectedItem == null)
                {
                    msgUsuario.Text = "Debe seleccionar un Rubro";
                    return;
                }
                int idRubro = (int)cbRubros.SelectedValue;
                //respuesta = dao.getTop5ProductosComprados(anio, trimestre, idRubro);
            }
            else if (metodo.Equals(ListadoEstadisticoDAO.Metodo.ProductosNoVendidosPorVisibilidad))
            {
                if (cbVisibilidades.SelectedItem == null)
                {
                    msgUsuario.Text = "Debe seleccionar una Visibilidad";
                    return;
                }
                int idVisibilidad = (int)cbVisibilidades.SelectedValue;
                //respuesta = dao.getTop5ProductosNoVendidos(anio, trimestre, idVisibilidad);
            }
            if (respuesta.CodigoError != 0)
            {
                msgUsuario.Text = respuesta.DescripcionError;
                return;
            }            
            listado.DataSource = respuesta.Resultado;

            if (respuesta.Resultado.Rows.Count == 0)
            {
                msgUsuario.Text = "No se encontraron resultados";
            }

        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            cbListaMetodos.SelectedItem = null;
            cbVisibilidades.SelectedItem = null;
            cbRubros.SelectedItem = null;
            cbTrimestres.SelectedItem = null;
            listado.DataSource = null;
            tbAnio.Text = "";
            msgUsuario.Text = "";
        }

        private void tbAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) {
                e.Handled = true;
                return;
            }
        }
    }
}
