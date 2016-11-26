using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class FrmRegistrarLlegada : Form
    {
        public FrmRegistrarLlegada()
        {
            InitializeComponent();
            CMBProfesional.Items.Clear();
            CMBAfiliado.Items.Clear();
            CMBEspecialidades.Items.Clear();
            CMBTurno.Items.Clear();
            loadPacientes();
            loadEspecialidades();
            loadProfesionales();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadProfesionales()
        {
            ProfesionalDAO prof = new ProfesionalDAO();
            DataTable tabla = prof.getProfesionales();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Persona per = new Persona();
                per.Nombre = (string)tabla.Rows[i][1];
                per.Apellido = (string)tabla.Rows[i][2];

                CMBProfesional.Items.Add(per.Nombre + "," + per.Apellido);
            }

        }

        private void loadPacientes()
        {
            PacienteDAO pacientes = new PacienteDAO();
            DataTable tabla = pacientes.getPacientes();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Persona per = new Persona();
                per.Nombre = (string) tabla.Rows[i][0];
                per.Apellido=(string) tabla.Rows[i][1];

                CMBAfiliado.Items.Add(per.Apellido+ ","+per.Nombre);
            }

        }

        private void loadEspecialidades()
        {
            EspecialidadMedicaDAO esp = new EspecialidadMedicaDAO();
            DataTable tabla = esp.getEspecialidades();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string detalle = (string) tabla.Rows[i][0];

                CMBEspecialidades.Items.Add(detalle);
            }
        }

        private void CMBEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProfesionalesXEspecialidad(CMBEspecialidades.Text);
        }

        private void loadProfesionalesXEspecialidad(string esp)
        {
            ProfesionalDAO especialidad = new ProfesionalDAO();
            DataTable tabla = especialidad.getProfesionalesXEspecialidad(esp);
            CMBProfesional.Items.Clear();
            CMBProfesional.Text = "Seleccione un profesional";

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Persona prof = new Persona();
                prof.Nombre = (string)tabla.Rows[i][0];
                prof.Apellido = (string)tabla.Rows[i][1];

                CMBProfesional.Items.Add(prof.Apellido + "," + prof.Nombre);
            }
        }

        private void CMBProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBAfiliado.Text != "Seleccione Profesional")
            {
                loadTurnos(CMBAfiliado.Text,CMBProfesional.Text);
            }
        }

        private void loadTurnos(string afi,string prof)
        {

            int id_afiliado = get_id_persona(afi);
            int id_profesional = get_id_persona(prof);
            DateTime fechaInicial = new DateTime();
            DateTime fechaActual = DateTime.Now;
            
            try
            {
                fechaInicial = Propiedades.getFechaActual;                
            }

            catch (Exception ex)
            {
                MessageBox.Show("La fecha configurada tiene un formato inválido: \n" + ex);
            }


            RegistrarAtencionDAO reg = new RegistrarAtencionDAO();
            DataTable tabla = reg.turnos(id_profesional, id_afiliado,fechaActual);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int turno = (int)tabla.Rows[i][0];
                DateTime fecha = (DateTime)tabla.Rows[i][1];

                CMBTurno.Items.Add(turno + "-" + fecha);
            }

            if (CMBTurno.Items.Count > 0)
            {
                CMBTurno.Enabled = true;
            }
   
        }

        private int get_id_persona(string persona)
        {
            RegistrarLlegadaDAO reg = new RegistrarLlegadaDAO();
            DataTable tabla = reg.get_id(persona);

            int id = (int)tabla.Rows[0][0];
            return id;
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if ((CMBTurno.Text != "Seleccione turno") & (CMBAfiliado.Text != "Seleccione Afiliado") & (CMBEspecialidades.Text != "Seleccione Especialidad") & (CMBProfesional.Text != "Seleccione Profesional"))
            {
                int id_afiliado = get_id_persona(CMBAfiliado.Text);
                int id_profesional = get_id_persona(CMBProfesional.Text);
                
                int fin = CMBTurno.Text.IndexOf("-") - 1;
                string sturno = CMBTurno.Text.Substring(0,fin);
                int turno =Int32.Parse(sturno);
                


            }
        }

        private void CMBAfiliado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBEspecialidades.Enabled = true;
            CMBProfesional.Enabled = true;
        }

        private void txtNumeroAfiliado_TextChanged(object sender, EventArgs e)
        {
            BuscarAfiliado(Int32.Parse(txtNumeroAfiliado.Text));
        }

        private void BuscarAfiliado(Int32 p)
        {
            RegistrarLlegadaDAO respuesta = new RegistrarLlegadaDAO();
            DataTable dt = new DataTable();

            dt = respuesta.GetNombre(p);

            CMBAfiliado.Text = (String)dt.Rows[0][0] + "," + (String)dt.Rows[0][1];
            
        }

      

    }
}
