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
        RegistrarAtencion atencion = new RegistrarAtencion();

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

            RegistrarAtencionDAO rd = new RegistrarAtencionDAO();

            
            rd.insertarRegistroAtencion(atencion);

            TXTDIAGNOSTICO.Text = "";
            TXTSINTOMAS.Text = "";
        }

       private void loadPacientes()
        {

            PacienteDAO pd = new PacienteDAO();
            DataTable dt = pd.getPacientesXProfesional(UsuarioLogueado.usuario.Id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Profesional p = new Profesional();
                p.Id = (int)dt.Rows[i][0];
                p.Nombre = (string)dt.Rows[i][1];
                p.Apellido = (string)dt.Rows[i][2];

                cmbPaciente.Items.Add(p.Apellido + " " + p.Nombre + " - " + p.Id);
            }
        }

      
        
    }
}
