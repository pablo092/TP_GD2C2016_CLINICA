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

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            LoadTipoListado();
        }

        private void LoadTipoListado()
        {
            Tipo_Listado.Items.Add("Top 5 especialidades que registran más cancelaciones");
            Tipo_Listado.Items.Add("Top 5 profesionales más consultados por Plan");
            Tipo_Listado.Items.Add("Top 5 profesionales con menos horas trabajadas");
            Tipo_Listado.Items.Add("Top 5 afiliados con mayor cantidad de bonos comprados");
            Tipo_Listado.Items.Add("Top 5 specialidades de médicos con más bonos de consultas utilizados");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Filtro_Extra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tipo_Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtro_Extra.Items.Clear();

            switch (Tipo_Listado.Text)
            {

                case "Top 5 especialidades que registran más cancelaciones":
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
                case "Top 5 profesionales más consultados por Plan":
                    {
                        L_Filtro_Extra.Show();
                        Filtro_Extra.Show();
                        Filtro_Extra.Text = "Seleccione Plan";
                        break;
                    }
                case "Top 5 profesionales con menos horas trabajadas":
                    {
                        L_Filtro_Extra.Show();
                        Filtro_Extra.Show();
                        Filtro_Extra.Text = "Seleccione Especialidad";
                        LoadEspecialidades();
                        break;
                    }
                case "Top 5 afiliados con mayor cantidad de bonos comprados":
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
                case "Top 5 specialidades de médicos con más bonos de consultas utilizados":
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
                default:
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
            }
            }

        private void LoadEspecialidades()
        {
            //generar metodo en DAO que haga la query. Metodo que llena el combo box con lo q trae del DAO
            DataTable especialidades = new DataTable();
            ListadoEstadisticoDAO DAO_especialidades = new ListadoEstadisticoDAO();
            especialidades = DAO_especialidades.getEspecialidades();
            
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                Filtro_Extra.Items.Add((String)especialidades.Rows[i][0]);
            }
        }
    }
}
