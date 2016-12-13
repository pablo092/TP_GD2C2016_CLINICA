using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;


namespace ClinicaFrba.Cancelar_Atencion
{

    /*** INICIALIZACIONES ***/

    public partial class FrmCancelarAtencion : Form
    {
        public FrmCancelarAtencion()
        {
            InitializeComponent();
        }

        private void FrmCancelarAtencion_Load(object sender, EventArgs e)
        {
            lblPersona.Text = GetPersonaPorUsuario(UsuarioLogueado.usuario.Id);
            

            if (UsuarioLogueado.usuario.Rol.Descripcion == "PROFESIONAL")
            {
                CHBDia.Visible = true;
                CHBPeriodo.Visible = true;
                DTPInicio.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+2);
                DTPFin.MinDate = DTPInicio.MinDate;
            }
            else
            {
                CHBPersonal.Visible = true;
                CHBFamiliar.Visible = true;
            }
            
        }

        private void loadTurnosUsuario(int usuario)
        {
            AfiliadoDAO afiliadoDao = new AfiliadoDAO();

            loadTurnos(afiliadoDao.GetNroAfiliadoPorUsuario(usuario));
        }

        private void loadFamiliares()
        {
            AfiliadoDAO familiares = new AfiliadoDAO();

            DataTable dt = new DataTable();

            dt = familiares.FamiliaresPorAfiliado(UsuarioLogueado.usuario.Id);

            if (dt.Rows.Count == 0)
            {
                CHBFamiliar.Checked = false;
                CHBFamiliar.Enabled = false;
                CMBFamiliar.Visible = false;
                lblFamiliar.Visible = false;
                MessageBox.Show("Sin familiares registrados", "Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    CMBFamiliar.Items.Add(Convert.ToString(dt.Rows[i][0]) + " - " + Convert.ToString(dt.Rows[i][1]) +
                                          "," + Convert.ToString(dt.Rows[i][2]));
                }
            }

        }

        private void loadTurnos(Int32 nro_afiliado)
        {
            CancelarAtencionDAO cancelacion = new CancelarAtencionDAO();

            DataTable dt = new DataTable();

            dt = cancelacion.GetFechasTurnos(nro_afiliado);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El afiliado no registra ningun turno", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CMBTurno.Enabled = true;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CMBTurno.Items.Add(Convert.ToString(dt.Rows[i][0]));
                }
            }

        }

        private string GetPersonaPorUsuario(int p)
        {
            CancelarAtencionDAO persona = new CancelarAtencionDAO();
            return persona.GetPersonaXUsuario(p);
        }

        /*** EVENTOS ***/
        private void CHBDia_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBDia.Checked == true)
            {
                CHBPeriodo.Checked = false;
                lblInicial.Text = "Fecha";
                lblInicial.Visible = true;
                DTPInicio.Visible = true;
                lblFinal.Visible = false;
                DTPFin.Visible = false;
                lblMotivo.Visible = true;
                TXTMotivo.Visible = true;
                BTNAceptar.Enabled = true;
            }
            else
            {
                lblInicial.Visible = false;
                DTPInicio.Visible = false;
                lblFinal.Visible = false;
                DTPFin.Visible = false;
                lblMotivo.Visible = false;
                TXTMotivo.Visible = false;
                BTNAceptar.Enabled = false;
            }
        }

        private void CHBPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBPeriodo.Checked == true)
            {
                CHBDia.Checked = false;
                lblInicial.Text = "Fecha inicial";
                lblInicial.Visible = true;
                DTPInicio.Visible = true;
                lblFinal.Visible = true;
                DTPFin.Visible = true;
                lblMotivo.Visible = true;
                TXTMotivo.Visible = true;
                BTNAceptar.Enabled = true;
            }
            else
            {
                lblInicial.Visible = false;
                DTPInicio.Visible = false;
                lblFinal.Visible = false;
                DTPFin.Visible = false;
                lblMotivo.Visible = false;
                TXTMotivo.Visible = false;
                BTNAceptar.Enabled = false;
            }

        }

        private void CHBPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBPersonal.Checked == true)
            {
                CHBFamiliar.Checked = false;
                lblTurno.Visible = true;
                CMBTurno.Visible = true;
                lblMotivo.Visible = true;
                TXTMotivo.Visible = true;
                BTNAceptar.Enabled = true;
                loadTurnosUsuario(UsuarioLogueado.usuario.Id);
            }
            else
            {
                CHBFamiliar.Checked = false;
                lblTurno.Visible = false;
                CMBTurno.Visible = false;
                lblMotivo.Visible = false;
                TXTMotivo.Visible = false;
                BTNAceptar.Enabled = false;
            }

        }

        private void CHBFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBFamiliar.Checked == true)
            {
                CHBPersonal.Checked = false;
                lblTurno.Visible = true;
                CMBTurno.Visible = true;
                lblMotivo.Visible = true;
                TXTMotivo.Visible = true;
                lblFamiliar.Visible = true;
                CMBFamiliar.Visible = true;
                BTNAceptar.Enabled = true;
                loadFamiliares();
            }
            else
            {
                CHBPersonal.Checked = false;
                lblTurno.Visible = false;
                CMBTurno.Visible = false;
                lblMotivo.Visible = false;
                TXTMotivo.Visible = false;
                lblFamiliar.Visible = false;
                CMBFamiliar.Visible = false;
                BTNAceptar.Enabled = false;
            }

        }

        private void TXTMotivo_Enter(object sender, EventArgs e)
        {
            TXTMotivo.SelectAll();
        }

        private void TXTMotivo_Leave(object sender, EventArgs e)
        {
            if ((TXTMotivo.Text == "") || (TXTMotivo.Text == " "))
            {
                TXTMotivo.Text = "Detalle motivo (Opcional)";
            }
        }

        private void DTPInicio_ValueChanged(object sender, EventArgs e)
        {
            DTPFin.MinDate = DTPInicio.Value;
            DTPFin.Value = DTPInicio.Value;
        }

        private void CMBFamiliar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 nro_afiliado = Convert.ToInt32(CMBFamiliar.Text.Substring(0,(CMBFamiliar.Text.IndexOf("-")-1)));

            loadTurnos(nro_afiliado);
        }

        /*** BOTONES***/

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            CancelarAtencionDAO cancelacion = new CancelarAtencionDAO();
            int cantidadTurnos;

            if (UsuarioLogueado.usuario.Rol.Descripcion == "PROFESIONAL")
            {
                DateTime inicio = new DateTime(DTPInicio.Value.Year, DTPInicio.Value.Month, DTPInicio.Value.Day, 7, 0, 0);
                DateTime fin = new DateTime(DTPFin.Value.Year, DTPFin.Value.Month, DTPFin.Value.Day, 20, 0, 0);
                Int32 id_profesional = cancelacion.GetIdPorUsuario(UsuarioLogueado.usuario.Id);
                if (CHBDia.Checked == true)
                {
                    cantidadTurnos = cancelacion.RegistrarCancelacionProfesional(inicio, fin, id_profesional, TXTMotivo.Text);
                }
                else
                {
                    cantidadTurnos = cancelacion.RegistrarCancelacionProfesional(inicio, fin, id_profesional, TXTMotivo.Text);
                }

                if (cantidadTurnos != 0)
                {
                    MessageBox.Show("Su cancelacion ha sido registrada.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else 
                {
                    MessageBox.Show("Su agenda no registra actividad para ese periodo.", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();

            }
            else
            {
                if (CMBTurno.Text != "")
                {
                    if (CHBPersonal.Checked == true)
                    {
                        Int32 afiliado = cancelacion.GetIdPorUsuario(UsuarioLogueado.usuario.Id);

                        Decimal turno = cancelacion.GetTurno(afiliado, CMBTurno.Text);

                        cancelacion.RegistrarCancelacionAfiliado(turno, TXTMotivo.Text);
                    }
                    else
                    {
                        Int32 afiliado = cancelacion.GetIdPorNroAfiliado(CMBFamiliar.Text);

                        Decimal turno = cancelacion.GetTurno(afiliado, CMBTurno.Text);

                        cancelacion.RegistrarCancelacionAfiliado(turno, TXTMotivo.Text);
                    }
                    MessageBox.Show("Su cancelacion ha sido registrada", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Debe elegir el turno a cancelar", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
   }

}

