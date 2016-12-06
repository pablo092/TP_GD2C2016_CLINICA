using ClinicaFrba.Administrador;
using ClinicaFrba.Common;
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


namespace ClinicaFrba.Registro_Resultado
{
    public partial class FrmRegistrarResultado : Form
    {
        
        public FrmRegistrarResultado()
        {
            InitializeComponent();
        }

        private void FrmRegistrarResultado_Load(object sender, EventArgs e)
        {
            loadPacientes();
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNACEPTAR_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex != -1)
            {
                decimal turno = getId_turno();

                RegistrarAtencionDAO rd = new RegistrarAtencionDAO();

                RegistrarAtencion ra = new RegistrarAtencion(TXTSINTOMAS.Text, TXTDIAGNOSTICO.Text, turno, DateTime.Now);

                rd.insertarRegistroAtencion(ra);

                MessageBox.Show("La atencion al afiliado "+ cmbPaciente.Text+" ha sido registrada", "Atencion registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el afiliado", "Registrar atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal getId_turno()
        {
            AfiliadoDAO pd = new AfiliadoDAO();

            int afiliado = pd.GetIdPorNroAfiliado(Convert.ToDecimal(cmbPaciente.Text.Substring(0, cmbPaciente.Text.IndexOf("-"))));

            int profesional = new PacienteDAO().getIdProfesional(UsuarioLogueado.usuario.Id);

            return new RegistrarAtencionDAO().turnos(profesional, afiliado);
        }

       private void loadPacientes()
        {

            PacienteDAO pd = new PacienteDAO();
            DataTable dt = pd.getPacientesXProfesional(UsuarioLogueado.usuario.Id);

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Afiliado afi = new Afiliado();
                    afi.Nombre = (string)dt.Rows[i][1];
                    afi.Apellido = (string)dt.Rows[i][2];

                    cmbPaciente.Items.Add(Convert.ToString(dt.Rows[i][0]) + " - " + afi.Apellido + " " + afi.Nombre);
                }
            }
            else
            {
                MessageBox.Show("No se registro la llegada de ninguno paciente", "Registro atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

      
        
    }
}
