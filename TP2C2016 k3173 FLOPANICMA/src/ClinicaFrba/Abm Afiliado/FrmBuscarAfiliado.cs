using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
using ClinicaFrba.ABM_Afiliado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ClinicaFrba.Abm_Afiliado
{

    public partial class FrmBuscarAfiliado : Form
    {
        /*** INICIALIZACIONES ***/
        Afiliado persona = new Afiliado();

        public FrmBuscarAfiliado()
        {
            InitializeComponent();
        }

        private void FrmBuscarAfiliado_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("SOLTERO/A");
            cmbEstado.Items.Add("CASADO/A");
            cmbEstado.Items.Add("CONCUBINATO");
            cmbEstado.Items.Add("DIVORCIADO/A");
            loadPlanes();
        }

        private void loadPlanes()
        {
            DataTable planes = new PlanDAO().getPlanes();

            if (planes.Rows.Count != 0)
            {
                for (int i = 0; i < planes.Rows.Count; i++)
                {
                    cmbPlanMedico.Items.Add(Convert.ToString(planes.Rows[i][0]));
                }
            }
            else
            {
                MessageBox.Show("No se han registrados planes medicos", "Ingreso datos de afiliado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarAfilado(String nroAfiliado)
        {
            if ((txtNroAfiliado.Text == "Ingrese numero de afiliado") || (txtNroAfiliado.Text == ""))
            {
                MessageBox.Show("Debe ingresar el numero de afiliado a modificar", "Modificar afiliado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AfiliadoDAO afiliadoDAO = new AfiliadoDAO();
                

                persona = afiliadoDAO.DatosAfiliadoPorNroAfiliado(Convert.ToInt32(nroAfiliado));

                if (persona.Nombre != "No se registra afiliado con ese numero")
                {
                    txtNombre.Text = persona.Apellido + ", " + persona.Nombre;
                    txtDireccion.Text = persona.Direccion;
                    txtTelefono.Text = persona.Telefono;
                    txtMail.Text = persona.Email;
                    cmbEstado.Text = persona.Estado_Civil;
                    cmbPlanMedico.Text = persona.PlanMedico;
                    nudFamiliares.Value = persona.Cantidad_Hijos;
                    HabilitarControles(true);
                }
                else
                {
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    txtMail.Text = "";
                    cmbEstado.Text = "";
                    nudFamiliares.Value = 0;
                    MessageBox.Show("El numero de afiliado no existe", "Modificar afiliado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HabilitarControles(false);
                    LimpiarCampos();
                }
            }
        }

        private void HabilitarControles(bool valor)
        {
            txtDireccion.Enabled = valor;
            txtTelefono.Enabled = valor;
            txtMail.Enabled = valor;
            txtDetalle.Enabled =valor;
            cmbEstado.Enabled = valor;
            nudFamiliares.Enabled = valor;
            btnAceptar.Enabled=valor;
            cmbPlanMedico.Enabled = valor;
        }

        private void LimpiarCampos()
        {
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtDetalle.Clear();
            nudFamiliares.Value = 0;
            cmbEstado.SelectedIndex = -1;
            cmbPlanMedico.SelectedIndex = -1;
            txtNombre.Clear();
        }

        /*** EVENTOS ***/
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.SelectAll();
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            txtMail.SelectAll();
        }

        private void cmbEstado_Enter(object sender, EventArgs e)
        {
            cmbEstado.SelectAll();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbEstado.SelectedIndex == 1) || (cmbEstado.SelectedIndex == 2))
            {
                chbAsociar.Visible = true;
                chbAsociar.Enabled = true;
            }
            else
            {
                chbAsociar.Checked = false;
                chbAsociar.Enabled = false;
                chbAsociar.Visible = false;
            }
        }

        private void cmbEstado_Leave(object sender, EventArgs e)
        {
            string estado = Convert.ToString(cmbEstado.Text.ToUpper());

            if ((cmbEstado.FindStringExact(estado)) == -1)
            {
                MessageBox.Show("El estado civil elegido no es valido", "Modificar estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstado.Focus();
            }
            else
            {
                cmbEstado.Text = estado.ToUpper();
            }
        }
        
        private void cmbPlanMedico_Leave(object sender, EventArgs e)
        {
            string plan = Convert.ToString(cmbPlanMedico.Text.ToUpper());

            if ((cmbPlanMedico.FindStringExact(plan)) == -1)
            {
                MessageBox.Show("El plan medico elegido no es valido", "Modificar estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPlanMedico.Focus();
            }
            else
            {
                cmbPlanMedico.Text = plan.ToUpper();
            }

        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                BuscarAfilado(txtNroAfiliado.Text);
            }
        }
        
        private void txtNroAfiliado_Enter(object sender, EventArgs e)
        {
            txtNroAfiliado.SelectAll();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }
        }

        private void nudFamiliares_ValueChanged(object sender, EventArgs e)
        {
            if (nudFamiliares.Value != persona.Cantidad_Hijos)
            {
                chbAsociarFamiliar.Enabled = true;
                chbAsociarFamiliar.Visible = true;
            }
            else
            {
                chbAsociarFamiliar.Checked = false;
                chbAsociarFamiliar.Enabled = false;
                chbAsociarFamiliar.Visible = false;
            }
        }

        private void cmbPlanMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetalle.Enabled = true;
        }

        private void txtDetalle_Enter(object sender, EventArgs e)
        {
            txtDetalle.SelectAll();
        }

        /*** BOTONES ***/
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAfilado(txtNroAfiliado.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtDireccion.Text != "") && (txtTelefono.Text != "") && (txtMail.Text != ""))
            {
                if ((!txtMail.Text.Contains("@")) || (!txtMail.Text.Contains(".com")))
                {
                    MessageBox.Show("El E-mail ingresado no es correcto", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int cantFamiliaresARegistrar = 0;
                    
                    if ((chbAsociar.Checked == true))
                    {
                        cantFamiliaresARegistrar = 1;

                        if (chbAsociarFamiliar.Checked == true)
                        {
                            if (nudFamiliares.Value > persona.Cantidad_Hijos)
                            {
                                cantFamiliaresARegistrar += (Convert.ToInt32(nudFamiliares.Value) - persona.Cantidad_Hijos);
                            }
                        }

                        for (int i = 0; i < cantFamiliaresARegistrar; i++)
                        {
                            FrmModificarAfiliado frmAgregarFamiliar = new FrmModificarAfiliado(Convert.ToInt32(txtNroAfiliado.Text));
                            frmAgregarFamiliar.ShowDialog();
                        }
                    }
                    else
                    {
                        if (chbAsociarFamiliar.Checked == true)
                        {
                            if (nudFamiliares.Value > persona.Cantidad_Hijos)
                            {
                                cantFamiliaresARegistrar = (Convert.ToInt32(nudFamiliares.Value) - persona.Cantidad_Hijos);
                            }

                            for (int i = 0; i < cantFamiliaresARegistrar; i++)
                            {
                                FrmModificarAfiliado frmAgregarFamiliar = new FrmModificarAfiliado(Convert.ToInt32(txtNroAfiliado.Text));
                                frmAgregarFamiliar.ShowDialog();
                            }
                        }
                    }

                    String detalle;

                    Afiliado afiliado = new Afiliado();

                    afiliado.PlanMedico = cmbPlanMedico.Text;
                    afiliado.Direccion = txtDireccion.Text;
                    afiliado.Telefono = txtTelefono.Text;
                    afiliado.Email = txtMail.Text;
                    afiliado.Estado_Civil = cmbEstado.Text;
                    afiliado.Cantidad_Hijos =Convert.ToInt32(nudFamiliares.Value);
                    afiliado.NroAfiliado = Convert.ToInt32(txtNroAfiliado.Text);

                    if (String.IsNullOrWhiteSpace(txtDetalle.Text))
                    {
                        detalle = "No especifica";
                    }
                    else
                    {
                        detalle = txtDetalle.Text;
                    }

                    new AfiliadoDAO().ActualizarAfiliado(afiliado, detalle);

                    MessageBox.Show("Los datos del afiliado han sido actualizados", "Actualizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControles(false);
                    LimpiarCampos();
                }

            }
            else
            {
                MessageBox.Show("Todos los campos deben ser cargados", "Modificar afiliado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
