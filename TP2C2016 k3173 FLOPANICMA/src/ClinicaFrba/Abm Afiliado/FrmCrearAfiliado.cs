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

            afiliado.Nombre = textBoxNombre.Text;
            afiliado.Apellido = textBoxApellido.Text;
            afiliado.TipoDocumento = "DNI";
            afiliado.NumeroDocumento = textBoxDNI.Text;
            afiliado.Direccion = textBoxDirec.Text;
            afiliado.Email = textBoxMail.Text;
            afiliado.PlanMedicoAnterior = (string)comboBoxPM.SelectedItem;
            afiliado.PlanMedicoActual = (string)comboBoxPM.SelectedItem;
            afiliado.Sexo = (string)comboBoxSexo.SelectedItem;
            afiliado.EstadoCivil = (string)comboBoxEstadoCivil.SelectedItem;
            afiliado.FechaNacimiento = dateTimePickerFecNac.Value;

            if (checkBoxAsociar.Enabled)
            {
                afiliado.CantHijos = (int)numericUpDownCantFam.Value;
            }
            if (checkBoxAsocPareja.Enabled)
            {
                pareja = 1;
            }
            adm.insertaAfiliado(afiliado);
            for (int i = 0; i <= afiliado.CantHijos + pareja; i++)
            {
            }
        }

        private void buttonCancelar_Cick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
