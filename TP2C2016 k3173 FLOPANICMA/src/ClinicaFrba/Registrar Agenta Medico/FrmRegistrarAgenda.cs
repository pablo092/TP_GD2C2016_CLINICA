using ClinicaFrba.Administrador;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class FrmRegistrarAgenda : Form
    {
        public FrmRegistrarAgenda()
        {
            InitializeComponent();
        }

        private void FrmRegistrarAgenda_Load(object sender, EventArgs e)
        {
            loadProfesionales();
            DTPInicio.MinDate = Propiedades.getFechaActual;
            DTPFin.MinDate = DTPInicio.Value;
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Respuesta resp = new Respuesta();

            if (CMBEspecialidad.Text != "Seleccione Profesional" && CMBEspecialidad.Text != "Seleccione Especialidad")
            {
                AgendaDAO agdao = new AgendaDAO();
                Agenda ag = new Agenda();
                String profesional = (string)CMBProfesionales.Text;
                int finCadena = profesional.IndexOf("-");
                profesional = profesional.Substring(0, finCadena);
                
                ag.IdProf = agdao.GetIdProfesional(profesional);
                ag.IdEsp = agdao.GetIdEspecialidad(CMBEspecialidad.Text);
                ag.PeriodoInicio = DTPInicio.Value;
                ag.PeriodoFin = DTPFin.Value;

                if (CHBLunes.Checked == true)
                {
                    ag.Dia = "Lunes";
                    ag.HoraInicio = (int)NUDInicioLunes.Value;
                    ag.HoraFin = (int)NUDFinLunes.Value;
                    resp = agdao.insertarAgenda(ag);
                }
                if (CHBMartes.Checked == true)
                {
                    ag.Dia = "Martes";
                    ag.HoraInicio = (int)NUDInicioMartes.Value;
                    ag.HoraFin = (int)NUDFinMartes.Value;
                    resp = agdao.insertarAgenda(ag);
                }

                if (CHBMiercoles.Checked == true)
                {
                    ag.Dia = "Miércoles";
                    ag.HoraInicio = (int)NUDInicioMiercoles.Value;
                    ag.HoraFin = (int)NUDFinMiercoles.Value;
                    resp = agdao.insertarAgenda(ag);
                }

                if (CHBJueves.Checked == true)
                {
                    ag.Dia = "Jueves";
                    ag.HoraInicio = (int)NUDInicioJueves.Value;
                    ag.HoraFin = (int)NUDFinJueves.Value;
                    resp = agdao.insertarAgenda(ag);
                }

                if (CHBViernes.Checked == true)
                {
                    ag.Dia = "Viernes";
                    ag.HoraInicio = (int)NUDInicioViernes.Value;
                    ag.HoraFin = (int)NUDFinViernes.Value;
                    resp = agdao.insertarAgenda(ag);
                }

                if (CHBSabado.Checked == true)
                {
                    ag.Dia = "Sábado";
                    ag.HoraInicio = (int)NUDInicioSabado.Value;
                    ag.HoraFin = (int)NUDFinSabado.Value;
                    resp = agdao.insertarAgenda(ag);
                }

                MessageBox.Show(resp.DescripcionError);
               

                CMBProfesionales.Refresh();
                CMBEspecialidad.Enabled = false;
                CMBEspecialidad.ResetText();
            }
            else
            {
                MessageBox.Show("Todos los campos indicados (*) deben estar completos");
            }
            
        }

        
        private void loadProfesionales()
        {
            
            ProfesionalDAO pd = new ProfesionalDAO();
            DataTable dt = pd.getProfesionales();

            for(int i=0; i < dt.Rows.Count; i++)
            {
                Profesional p = new Profesional();
                p.Id = (int)dt.Rows[i][0];
                p.Nombre = (string)dt.Rows[i][1];
                p.Apellido = (string)dt.Rows[i][2];

                CMBProfesionales.Items.Add(p.Apellido + "," + p.Nombre+"-"+p.Id);
            }
        }

        private void comboBoxProfesionales_Click(object sender, EventArgs e)
        {
            string profSelected = (string)CMBProfesionales.SelectedItem;
            int ini = profSelected.IndexOf("-")+1;
            int fin = profSelected.Length;
            string s = profSelected.Substring(ini, 4);
            int id_prof = Int32.Parse(s);
            CMBEspecialidad.Items.Clear();
            
            EspecialidadMedicaDAO em = new EspecialidadMedicaDAO();
            DataTable dt = em.getEspecialidadesByProfesional(id_prof);

            for(int i=0; i < dt.Rows.Count; i++)
            {
                CMBEspecialidad.Items.Add(dt.Rows[i][0]);
            }
            CMBEspecialidad.Enabled = true;
            CMBEspecialidad.Text = "Seleccione Especialidad";
        }

        private void NUDInicio_ValueChanged(object sender, EventArgs e)
        {
            NUDFinLunes.Minimum = NUDInicioLunes.Value + 1;
            NUDFinLunes.Value = NUDInicioLunes.Value + 1;

        }

        private void NUDInicioMartes_ValueChanged(object sender, EventArgs e)
        {
            NUDFinMartes.Minimum = NUDInicioMartes.Value + 1;
            NUDFinMartes.Value = NUDInicioMartes.Value + 1;
        }

        private void NUDInicioMiercoles_ValueChanged(object sender, EventArgs e)
        {
            NUDFinMiercoles.Minimum = NUDInicioMiercoles.Value + 1;
            NUDFinMiercoles.Value = NUDInicioMiercoles.Value + 1;
        }

        private void NUDInicioJueves_ValueChanged(object sender, EventArgs e)
        {
            NUDFinJueves.Minimum = NUDInicioJueves.Value + 1;
            NUDFinJueves.Value = NUDInicioJueves.Value + 1;
        }

        private void NUDInicioViernes_ValueChanged(object sender, EventArgs e)
        {
            NUDFinViernes.Minimum = NUDInicioViernes.Value + 1;
            NUDFinViernes.Value = NUDInicioViernes.Value + 1;
        }

        private void NUDInicioSabado_ValueChanged(object sender, EventArgs e)
        {
            NUDFinSabado.Minimum = NUDInicioSabado.Value + 1;
            NUDFinSabado.Value = NUDInicioSabado.Value + 1;
        }

        private void CHBLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBLunes.Checked == true)
            {
                lbl11.Show();
                lbl12.Show();
                lbl13.Show();
                lbl14.Show();
                NUDInicioLunes.Show();
                NUDFinLunes.Show();
            }
            else
            {
                lbl11.Hide();
                lbl12.Hide();
                lbl13.Hide();
                lbl14.Hide();
                NUDInicioLunes.Hide();
                NUDFinLunes.Hide();
            }

        }

        private void CHBMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBMartes.Checked == true)
            {
                lbl21.Show();
                lbl22.Show();
                lbl23.Show();
                lbl24.Show();
                NUDInicioMartes.Show();
                NUDFinMartes.Show();
            }
            else
            {
                lbl21.Hide();
                lbl22.Hide();
                lbl23.Hide();
                lbl24.Hide();
                NUDInicioMartes.Hide();
                NUDFinMartes.Hide();
            }
        }

        private void CHBMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBMiercoles.Checked == true)
            {
                lbl31.Show();
                lbl32.Show();
                lbl33.Show();
                lbl34.Show();
                NUDInicioMiercoles.Show();
                NUDFinMiercoles.Show();
            }
            else
            {
                lbl31.Hide();
                lbl32.Hide();
                lbl33.Hide();
                lbl34.Hide();
                NUDInicioMiercoles.Hide();
                NUDFinMiercoles.Hide();
            }
        }

        private void CHBJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBJueves.Checked == true)
            {
                lbl41.Show();
                lbl42.Show();
                lbl43.Show();
                lbl44.Show();
                NUDInicioJueves.Show();
                NUDFinJueves.Show();
            }
            else
            {
                lbl41.Hide();
                lbl42.Hide();
                lbl43.Hide();
                lbl44.Hide();
                NUDInicioJueves.Hide();
                NUDFinJueves.Hide();
            }
        }

        private void CHBViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBViernes.Checked == true)
            {
                lbl51.Show();
                lbl52.Show();
                lbl53.Show();
                lbl54.Show();
                NUDInicioViernes.Show();
                NUDFinViernes.Show();
            }
            else
            {
                lbl51.Hide();
                lbl52.Hide();
                lbl53.Hide();
                lbl54.Hide();
                NUDInicioViernes.Hide();
                NUDFinViernes.Hide();
            }
        }

        private void CHBSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBSabado.Checked == true)
            {
                lbl61.Show();
                lbl62.Show();
                lbl63.Show();
                lbl64.Show();
                NUDInicioSabado.Show();
                NUDFinSabado.Show();
            }
            else
            {
                lbl61.Hide();
                lbl62.Hide();
                lbl63.Hide();
                lbl64.Hide();
                NUDInicioSabado.Hide();
                NUDFinSabado.Hide();
            }
        }

        private void DTPInicio_ValueChanged(object sender, EventArgs e)
        {
            DTPFin.MinDate = DTPInicio.Value;
        }

       
    }
}
