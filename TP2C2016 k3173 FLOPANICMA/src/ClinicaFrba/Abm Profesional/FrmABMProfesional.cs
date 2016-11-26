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

namespace ClinicaFrba.Abm_Profesional
{
    public partial class FrmABMProfesional : Form
    {
        public FrmABMProfesional()
        {
            InitializeComponent();
            cargarComboBox();
            cargarCheckedEspecialidades();
        }

        private void FrmABMProfesional_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cargarComboBox()
        {
            comboBoxSexo.Items.Add(Sexo.Masculino);
            comboBoxSexo.Items.Add(Sexo.Femenino);

            comboBoxDNI.Items.Add(TipoDocumento.DNI);
        }

        private void cargarCheckedEspecialidades()
        {
            TipoEspecialidadDAO ted = new TipoEspecialidadDAO();
            DataTable dt = ted.getAllTipoEspecialidades();

            for(int i=0; i < dt.Rows.Count; i++)
            {
                checkedListBoxEspecialidades.Items.Add(dt.Rows[i][1]);
            }
        }
    }
}
