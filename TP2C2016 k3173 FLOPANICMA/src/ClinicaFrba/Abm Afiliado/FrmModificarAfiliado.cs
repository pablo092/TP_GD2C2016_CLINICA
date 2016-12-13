using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class FrmModificarAfiliado : Form
    {
        bool raiz = new bool();
        int nro_raiz = new int();
        /*** INICIALIZACIONES ***/
        public FrmModificarAfiliado()
        {
            InitializeComponent();
            raiz = true;
        }

        public FrmModificarAfiliado(int nro)
        {
            InitializeComponent();
            raiz = false;
            nro_raiz = nro;
        }

        private void FrmModificarAfiliado_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("SOLTERO/A");
            cmbEstado.Items.Add("CASADO/A");
            cmbEstado.Items.Add("CONCUBINATO");
            cmbEstado.Items.Add("DIVORCIADO/A");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
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
                    MessageBox.Show("No se han registrados planes medicos","Ingreso datos de afiliado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
        }

        /*** EVENTOS ***/
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.SelectAll();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtApellido.Focus();
            }

            if (!(caracter >= 65 && caracter <= 90) && !(caracter >= 97 && caracter <= 122) && (!char.IsSeparator(caracter)) && (caracter != 8))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                epCampoVacio.SetError(txtNombre, "Ingrese el nombre del afiliado");
                txtApellido.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                epCampoVacio.Clear();
            }
        }

        //txtApellido

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtApellido.SelectAll();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            cmbTipoDocumento.Enabled = true;
            txtDNI.Enabled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtDNI.Focus();
            }

            if (!(caracter >= 65 && caracter <= 90) && !(caracter >= 97 && caracter <= 122) && (!char.IsSeparator(caracter)) && (caracter != 8))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                cmbTipoDocumento.Enabled = false;
                txtDNI.Enabled = false;
                btnGuardar.Enabled = false;
                epCampoVacio.SetError(txtApellido, "Debe ingresar el apellido");
            }
            else
            {
                epCampoVacio.Clear();
            }
        }

        //txtDNI + Validacion que la persona a registrar no este ya en la base 
        //a traves de la de la existencia del numero de documento en la misma

        private void txtDNI_Enter(object sender, EventArgs e)
        {
            txtDNI.SelectAll();
        }
        
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Enabled = true;
            txtDireccion.Enabled = true;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDNI.Text))
            {
                dtpFechaNacimiento.Enabled = false;
                txtDireccion.Enabled = false;
                btnGuardar.Enabled = false;
                epCampoVacio.SetError(txtDNI, "Ingrese numero de documento");
            }
            else
            {
                if (PersonaYaRegistrada(Convert.ToDecimal(txtDNI.Text)))
                {
                    MessageBox.Show("El afiliado ya esta registrado", "Registrar afiliado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reiniciarFormulario();
                }
                else
                {
                    epCampoVacio.Clear();
                }
            }
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                cmbTipoDocumento.SelectedIndex = 0;
            }
        }

        private void reiniciarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellido.Enabled = false;
            txtDNI.Clear();
            txtDNI.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtDireccion.Clear();
            txtDireccion.Enabled = false;
            txtTelefono.Clear();
            txtTelefono.Enabled = false;
            txtMail.Clear();
            txtMail.Enabled = false;
            cmbTipoDocumento.SelectedIndex = -1;
            cmbTipoDocumento.Enabled = false;
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Enabled = false;
            cmbPlanMedico.SelectedIndex = -1;
            cmbPlanMedico.Enabled = false;
            cmbSexo.SelectedIndex = -1;
            cmbSexo.Enabled = false;
            nudCantFam.Value = 0;
            txtNroAfil.Clear();
            epCampoVacio.Clear();
        }

        private bool PersonaYaRegistrada(decimal nro)
        {
            return new AfiliadoDAO().AfiliadoRegistrado(nro);
        }


        // txtDireccion
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.SelectAll();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.Enabled = true;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtTelefono.Enabled = false;
                btnGuardar.Enabled = false;
                epCampoVacio.SetError(txtDireccion, "Ingrese direccion");
            }
            else
            {
                epCampoVacio.Clear();
            }
        }

        //txtTelefono
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtMail.Enabled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }

            if (caracter == Convert.ToChar(Keys.Enter))
            {
                txtMail.Focus();
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {

        }

        //txtMail y txtMail2
        private void txtMail_Enter(object sender, EventArgs e)
        {
            txtMail.SelectAll();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMail.Text))
            {
                cmbPlanMedico.Enabled = true;
                cmbSexo.Enabled = true;
                cmbEstado.Enabled = true;
                nudCantFam.Enabled = true;
                btnGuardar.Enabled = true;
                epCampoVacio.Clear();
            }
            else
            {
                epCampoVacio.SetError(txtMail, "Ingrese direccion de E-Mail");
                cmbEstado.Enabled = false;
                cmbSexo.Enabled = false;
                cmbPlanMedico.Enabled = false;
                nudCantFam.Enabled = true;
            }

        }
        //Resto de los controles

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raiz == true)
            {
                if ((cmbEstado.SelectedIndex == 1) || (cmbEstado.SelectedIndex == 2))
                {
                    chbAsociar.Enabled = true;
                    chbAsociar.Visible = true;
                }
                else
                {
                    chbAsociar.Enabled = false;
                    chbAsociar.Checked = false;
                    chbAsociar.Visible = false;
                }
            }
        }
        
        private void nudCantFam_ValueChanged(object sender, EventArgs e)
        {
            if (raiz == true)
            {
                if (nudCantFam.Value > 0)
                {
                    chbAsociarFamiliar.Enabled = true;
                    chbAsociarFamiliar.Visible = true;
                }
                else
                {
                    chbAsociarFamiliar.Enabled = false;
                    chbAsociarFamiliar.Visible = false;
                    chbAsociarFamiliar.Checked = false;
                }
            }
        }


        /*** BOTONES ***/
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if ((!txtMail.Text.Contains("@")) || (!txtMail.Text.Contains(".com")))
            {
                epCampoVacio.SetError(txtMail, "El E-mail ingresado no es valido");
            }
            else
            {
                if (cmbEstado.SelectedIndex == -1)
                {
                    epCampoVacio.SetError(cmbEstado, "Seleccione estado civil");
                }
                else
                {
                    if (cmbPlanMedico.SelectedIndex == -1)
                    {
                        epCampoVacio.SetError(cmbPlanMedico, "Seleccione plan medico");
                    }
                    else
                    {
                        if (cmbSexo.SelectedIndex == -1)
                        {
                            epCampoVacio.SetError(cmbSexo, "Seleccione genero");
                        }
                        else
                        {
                            int nro_afiliado = new int();
                            int cantFamiliaresARegistrar = 0;
                            epCampoVacio.Clear();
                         
                            Afiliado afiliado = new Afiliado();
                            afiliado.Nombre = txtNombre.Text;
                            afiliado.Apellido = txtApellido.Text;
                            afiliado.Direccion = txtDireccion.Text;
                            afiliado.NumeroDocumento = Convert.ToInt32(txtDNI.Text);
                            afiliado.FechaNacimiento = dtpFechaNacimiento.Value;
                            afiliado.Telefono = txtTelefono.Text;
                            afiliado.Email = txtMail.Text;
                            afiliado.PlanMedico = Convert.ToString(new PlanDAO().GetIdPlanPorDescripcion(cmbPlanMedico.Text));
                            afiliado.Sexo = cmbSexo.Text;
                            afiliado.Estado_Civil = cmbEstado.Text;
                            afiliado.TipoDocumento = cmbTipoDocumento.Text;
                            afiliado.Cantidad_Hijos = Convert.ToInt32(nudCantFam.Value);

                            if (raiz == true)
                            {
                                 nro_afiliado = new AfiliadoDAO().RegistrarAfiliado(afiliado);
                            }
                            else
                            {
                                 nro_afiliado = new AfiliadoDAO().RegistarFamiliar(afiliado, nro_raiz);
                            }

                            txtNroAfil.Text = Convert.ToString(nro_afiliado);
                            int id_afiliado= new AfiliadoDAO().GetIdPorNroAfiliado(Convert.ToDecimal(txtNroAfil.Text));

                            if (chbAsociar.Checked == true)
                            {
                                cantFamiliaresARegistrar = 1;
                                if (chbAsociarFamiliar.Checked==true)
                                {
                                    cantFamiliaresARegistrar+= Convert.ToInt32(nudCantFam.Value);
                                }

                                MessageBox.Show("Su nombre de usuario es: afil" + Convert.ToString(id_afiliado) + "\nSu contraseña inicial es: w23e", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                                MessageBox.Show("El afiliado ha sido registrado, proceda a registrar a los familiares","Registro afiliado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                 
                                for(int i=0;i<cantFamiliaresARegistrar;i++)
                                {
                                    FrmModificarAfiliado frmModificarAfiliado = new FrmModificarAfiliado(nro_afiliado);
                                    frmModificarAfiliado.ShowDialog();
                                }
                            }
                            else
                            {
                                if(chbAsociarFamiliar.Checked==true)
                                {
                                    cantFamiliaresARegistrar = Convert.ToInt32(nudCantFam.Value);

                                    MessageBox.Show("Su nombre de usuario es: afil" + Convert.ToString(id_afiliado) + "\nSu contraseña inicial es: w23e", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("El afiliado ha sido registrado, proceda a registrar a los familiares","Registro afiliado",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                    for (int i = 0; i<cantFamiliaresARegistrar;i++)
                                    {
                                        FrmModificarAfiliado frmModificarAfiliado = new FrmModificarAfiliado(nro_afiliado);
                                        frmModificarAfiliado.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Su nombre de usuario es: afil" + Convert.ToString(id_afiliado) + "\nSu contraseña inicial es: w23e", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                     MessageBox.Show("El afiliado ha sido registrado", "Registro Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                     if(raiz==false)
                                     {
                                         this.Close();
                                     }
                                    
                                }
                            }

                            btnGuardar.Enabled = false;
                            btnReiniciar.Visible = true;
                            btnReiniciar.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarFormulario();
            btnReiniciar.Visible = false;
            btnGuardar.Visible = true;
        }

        

        

        

    }
}
