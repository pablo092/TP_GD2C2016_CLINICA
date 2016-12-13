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
    public partial class FrmListadoEstadistico : Form
    {

        /*** INICIALIZACIONES ***/      
        public FrmListadoEstadistico()
        {
            InitializeComponent();
            
        }

        private void FrmListadoEstadistico_Load(object sender, EventArgs e)
        {
            LoadTipoListado();
        }

        private void LoadTipoListado()
        {
            Tipo_Listado.Items.Add("Especialidades que registran más cancelaciones");
            Tipo_Listado.Items.Add("Profesionales más consultados por Plan");
            Tipo_Listado.Items.Add("Profesionales con menos horas trabajadas");
            Tipo_Listado.Items.Add("Afiliados con mayor cantidad de bonos comprados");
            Tipo_Listado.Items.Add("Especialidades de médicos con más bonos de consultas utilizados");
        }

        private void LoadEspecialidades()
        {
            DataTable especialidades = new DataTable();
            ListadoEstadisticoDAO DAO_especialidades = new ListadoEstadisticoDAO();
            especialidades = DAO_especialidades.getEspecialidades();

            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                Filtro_Extra.Items.Add((String)especialidades.Rows[i][0]);
            }
        }

        private void loadPlanes()
        {
            DataTable planes = new DataTable();
            PlanDAO plandao = new PlanDAO();

            planes = plandao.getPlanes();

            for (int i = 0; i < planes.Rows.Count; i++)
            {
                Filtro_Extra.Items.Add(Convert.ToString(planes.Rows[i][0]));
            }
        }

        /*** EVENTOS ***/

        private void Tipo_Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtro_Extra.Items.Clear();

            switch (Tipo_Listado.Text)
            {

                case "Especialidades que registran más cancelaciones":
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
                case "Profesionales más consultados por Plan":
                    {
                        L_Filtro_Extra.Show();
                        Filtro_Extra.Show();
                        Filtro_Extra.Text = "Seleccione Plan";
                        loadPlanes();
                        break;
                    }
                case "Profesionales con menos horas trabajadas":
                    {
                        L_Filtro_Extra.Show();
                        Filtro_Extra.Show();
                        Filtro_Extra.Text = "Seleccione Especialidad";
                        LoadEspecialidades();
                        break;
                    }
                case "Afiliados con mayor cantidad de bonos comprados":
                    {
                        Filtro_Extra.Hide();
                        L_Filtro_Extra.Hide();
                        break;
                    }
                case "Especialidades de médicos con más bonos de consultas utilizados":
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

        private void CMBSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBMes.Items.Clear();

            if (CMBSemestre.Text == "1er Semestre")
            {
                CMBMes.Items.Add("Semestre");
                CMBMes.Items.Add("Enero");
                CMBMes.Items.Add("Febrero");
                CMBMes.Items.Add("Marzo");
                CMBMes.Items.Add("Abril");
                CMBMes.Items.Add("Mayo");
                CMBMes.Items.Add("Junio");
            }
            else
            {
                CMBMes.Items.Add("Semestre");
                CMBMes.Items.Add("Julio");
                CMBMes.Items.Add("Agosto");
                CMBMes.Items.Add("Septiembre");
                CMBMes.Items.Add("Octubre");
                CMBMes.Items.Add("Noviembre");
                CMBMes.Items.Add("Diciembre");
            }
        }

        private Int32 SemestreNro(String semestre)
        {
            if (semestre == "1er Semestre")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private Int32 MesNro(Int32 mes)
        {
            if (SemestreNro(CMBSemestre.Text) == 2)
            {
                if (mes != 0)
                {
                    return (mes + 6);
                }
                else
                {
                    return mes;
                }
            }
            else
            {
                return mes;
            }
        }

        /***  BOTONES ***/

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (CMBMes.SelectedIndex == -1)// -1 indica que no se ha elegido ningun elemento del combo box
            {
                CMBMes.SelectedIndex = 0; //por defecto selecciona el semestre que se representa com el mes 0
            }

            if (CMBSemestre.SelectedIndex == -1)// -1 indica que no se ha elegido ningun elemento del combo box
            {
                MessageBox.Show("Debe seleccionar semestre a mostrar", "Semestre",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ListadoEstadisticoDAO listado = new ListadoEstadisticoDAO();
                Int32 nro_semestre = new Int32();
                Int32 nro_mes = new Int32();

                nro_semestre = SemestreNro(CMBSemestre.Text);
                nro_mes = MesNro(CMBMes.SelectedIndex);

                switch (Tipo_Listado.Text)
                {

                    case "Especialidades que registran más cancelaciones":
                        {
                            DGVListados.DataSource = listado.ListadoEspConMasCancelaciones(Convert.ToInt32(NUDAnio.Value), nro_semestre, nro_mes);
                            break;
                        }
                    case "Profesionales más consultados por Plan":
                        {
                            if (Filtro_Extra.Text != "Seleccione Plan")
                            {
                                DGVListados.DataSource = listado.ListadoProfMasConsultadosPorPlan(Convert.ToInt32(NUDAnio.Value), nro_semestre, nro_mes, Filtro_Extra.Text);
                            }
                            else
                            {
                                MessageBox.Show("Seleccione Plan", "Plan");
                            }

                            break;
                        }
                    case "Profesionales con menos horas trabajadas":
                        {
                            if (Filtro_Extra.Text != "Seleccione Especialidad")
                            {
                                DGVListados.DataSource = listado.ListadoProfMenosHorasPorEspecialidad(Convert.ToInt32(NUDAnio.Value), nro_semestre, nro_mes, Filtro_Extra.Text);
                            }
                            else
                            {
                                MessageBox.Show("Seleccione especialidad", "Especialidad");
                            }
                            break;
                        }
                    case "Afiliados con mayor cantidad de bonos comprados":
                        {
                            
                            DGVListados.DataSource = listado.ListadoMasBonosComprados(Convert.ToInt32(NUDAnio.Value), nro_semestre, nro_mes);
                            break;
                        }
                    case "Especialidades de médicos con más bonos de consultas utilizados":
                        {
                            DGVListados.DataSource = listado.ListadoEspConMasBonos(Convert.ToInt32(NUDAnio.Value), nro_semestre, nro_mes);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Seleccione un tipo de listado a mostrar", "Tipo de Listado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                }

                // Vuelve las celdas del DataGridView a solo lectura
                for (int i = 0; i < DGVListados.Columns.Count; i++)
                {
                    DGVListados.Columns[i].ReadOnly = true;
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
