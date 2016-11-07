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

namespace ClinicaFrba.Abm_Planes
{
    public partial class FrmBuscarPlan : Form
    {
        public FrmBuscarPlan()
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
            PlanDAO p = new PlanDAO();
            DataTable dt = p.getPlanes();

            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;

            this.dataGridViewPlanes.AutoGenerateColumns = true;
            this.dataGridViewPlanes.DataSource = dt;

            this.dataGridViewPlanes.DataSource = SBind;
            this.dataGridViewPlanes.Refresh();

        }
    }
}
