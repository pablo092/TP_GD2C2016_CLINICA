using ClinicaFrba.AdministradorDao;
using ClinicaFrba.Common;
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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class FrmCrearAfiliado : Form
    {
        Afiliado afiliado = new Afiliado();

        public FrmCrearAfiliado()
        {
            InitializeComponent();
            this.ocultarItemes();
            this.cargarComboBox();
        }

        /* MODIFICAR */
        public FrmCrearAfiliado(Afiliado a)
        {
            InitializeComponent();
            this.Text = "EDITAR AFILIADO";
            afiliado = a;

            textBoxNombre.Text = afiliado.Nombre;
            textBoxNombre.Enabled = false;
            textBoxApellido.Text = afiliado.Apellido;
            textBoxApellido.Enabled = false;
            textBoxDNI.Text = afiliado.NumeroDocumento;
            textBoxDNI.Enabled = false;
            textBoxDirec.Text = afiliado.Direccion;
            textBoxMail.Text = afiliado.Email;
            comboBoxPM.Items.Add(afiliado.PlanMedicoAnterior);
            comboBoxSexo.Items.Add(afiliado.Sexo);
            comboBoxSexo.Enabled = false;
            comboBoxEstadoCivil.Items.Add(afiliado.EstadoCivil);
            numericUpDownCantFam.Value = afiliado.CantHijos;
            dateTimePickerFecNac.Value = afiliado.FechaNacimiento;
            dateTimePickerFecNac.Enabled = false;
            textBoxNroAfil.Text = afiliado.NroAfiliado;
            textBoxNroAfil.Enabled = false;

            checkBoxAsociar.Visible = false;
            checkBoxAsocPareja.Visible = false;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            AdministradorAfiliado adm = new AdministradorAfiliado();
            int pareja = 0;

            if (checkBoxAsociar.Checked)
            {
                afiliado.CantHijos = (int)numericUpDownCantFam.Value;
            }
            if (checkBoxAsocPareja.Checked)
            {
                pareja = 1;
            }

            afiliado.Nombre = textBoxNombre.Text;
            afiliado.Apellido = textBoxApellido.Text;
            afiliado.TipoDocumento = "DNI";
            afiliado.NumeroDocumento = textBoxDNI.Text;
            afiliado.Direccion = textBoxDirec.Text;
            afiliado.Email = textBoxMail.Text;
            afiliado.PlanMedicoAnterior = (string)comboBoxPM.SelectedItem;
            afiliado.PlanMedicoActual = (string)comboBoxPM.SelectedItem;
            afiliado.Sexo = comboBoxSexo.SelectedText;
            afiliado.EstadoCivil = comboBoxEstadoCivil.SelectedText;
            afiliado.FechaNacimiento = dateTimePickerFecNac.Value;

            adm.insertaAfiliado(afiliado);

            for (int i = 0; i <= afiliado.CantHijos + pareja; i++)
            {
                FrmCrearAfiliado fmrAfil = new FrmCrearAfiliado();
            }
        }

        private void buttonCancelar_Cick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarComboBox()
        {
            comboBoxSexo.Items.Add(Sexo.Masculino);
            comboBoxSexo.Items.Add(Sexo.Femenino);

            comboBoxPM.Items.Add("Plan Medico 110");
            comboBoxPM.Items.Add("Plan Medico 120");
            comboBoxPM.Items.Add("Plan Medico 130");
            comboBoxPM.Items.Add("Plan Medico 140");
            comboBoxPM.Items.Add("Plan Medico 150");

            comboBoxEstadoCivil.Items.Add(EstadoCivil.Soltero);
            comboBoxEstadoCivil.Items.Add(EstadoCivil.Casado);
            comboBoxEstadoCivil.Items.Add(EstadoCivil.Concubinato);
            comboBoxEstadoCivil.Items.Add(EstadoCivil.Divorciado);
        }

        private void ocultarItemes()
        {
            this.textBoxNroAfil.Visible = false;
            this.labelNroAfil.Visible = false;
            this.checkBoxAsociar.Visible = false;
            this.checkBoxAsocPareja.Visible = false;
        }

        private void comboBoxEstadoCivil_Click(object sender, EventArgs e)
        {
            object estado = comboBoxEstadoCivil.SelectedItem;
            if (EstadoCivil.Casado.Equals(estado) || EstadoCivil.Concubinato.Equals(estado))
            {
                this.checkBoxAsocPareja.Visible = true;
            }
            else
            {
                this.checkBoxAsocPareja.Visible = false;
            }
        }

        private void numericUpDownCantFam_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownCantFam.Value > 0)
            {
                this.checkBoxAsociar.Visible = true;
            }
            else
            {
                this.checkBoxAsociar.Visible = false;
            }
        }

    }
}
