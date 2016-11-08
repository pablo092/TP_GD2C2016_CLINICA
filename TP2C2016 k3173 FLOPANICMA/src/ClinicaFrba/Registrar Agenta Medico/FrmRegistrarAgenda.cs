using ClinicaFrba.Administrador;
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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class FrmRegistrarAgenda : Form
    {
        public FrmRegistrarAgenda()
        {
            InitializeComponent();
            loadProfesionales();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            AdministradorAgenda adm = new AdministradorAgenda();

            Agenda a = new Agenda(new DateTime());

            adm.insertaAgenda(a);
        }

        private void numericUpDownSegIni_Click(object sender, EventArgs e)
        {
            if (numericUpDownMinIni.Value > 59)
            {
                this.numericUpDownHoraIni.Value += 1;
                this.numericUpDownMinIni.Value = 0;
            }
        }

        private void numericUpDownSegFin_Click(object sender, EventArgs e)
        {
            if (numericUpDownMinFin.Value > 59)
            {
                this.numericUpDownHoraFin.Value += 1;
                this.numericUpDownMinFin.Value = 0;
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

                comboBoxProfesionales.Items.Add(p.Apellido + "," + p.Nombre + "-" + p.Id);
            }
        }

        private void comboBoxProfesionales_Click(object sender, EventArgs e)
        {
            string profSelected = (string)comboBoxProfesionales.SelectedItem;
            int ini = profSelected.IndexOf("-") + 1;
            int fin = profSelected.Length;
            string s = profSelected.Substring(ini, fin);
            int id_prof = Int32.Parse(s);

            EspecialidadMedicaDAO em = new EspecialidadMedicaDAO();
            DataTable dt = em.getEspecialidadesByProfesional(id_prof);

            for(int i=0; i < dt.Rows.Count; i++)
            {
                comboBoxEspecialidad.Items.Add(dt.Rows[i][0]);
            }
        }
    }
}
