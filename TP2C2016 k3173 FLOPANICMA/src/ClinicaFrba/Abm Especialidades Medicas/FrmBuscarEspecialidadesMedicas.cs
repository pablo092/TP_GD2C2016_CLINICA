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

namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    public partial class FrmBuscarEspecialidadesMedicas : Form
    {
        public FrmBuscarEspecialidadesMedicas()
        {
            InitializeComponent();
            loadTable();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadTable()
        {
            EspecialidadMedicaDAO em = new EspecialidadMedicaDAO();
            DataTable dt = em.getAllEspecialidades();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;

            this.dataGridViewEspMed.AutoGenerateColumns = true;
            this.dataGridViewEspMed.DataSource = dt;

            this.dataGridViewEspMed.DataSource = SBind;
            this.dataGridViewEspMed.Refresh();

        }
    }
}
