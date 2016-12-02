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

namespace ClinicaFrba.HistorialModificacionesPlan
{
    public partial class FrmHistModifPlan : Form
    {
        public FrmHistModifPlan()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNroAfiliado.Text.Equals("") || this.textBoxNroAfiliado.Text == null)
            {
                MessageBox.Show("Ingrese un numero de afiliado");
                return;
            }

            HistorialModifPlanDAO hist = new HistorialModifPlanDAO();

            DataTable dt = hist.getHistModifByNroAfil(Int32.Parse(this.textBoxNroAfiliado.Text));

            BindingSource SBind = new BindingSource();
            SBind.DataSource = dt;

            this.dataGridViewResultados.AutoGenerateColumns = true;
            this.dataGridViewResultados.DataSource = dt;

            this.dataGridViewResultados.DataSource = SBind;
            this.dataGridViewResultados.Refresh();
        }
    }
}
