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
        /*** INICIALIZACIONES ***/
        public FrmRegistrarLlegada()
        {
            InitializeComponent();
        }

        private void FrmRegistrarLlegada_Load(object sender, EventArgs e)
        {
            CMBProfesional.Items.Clear();
            CMBAfiliado.Items.Clear();
            CMBEspecialidades.Items.Clear();
            CMBTurno.Items.Clear();
            loadPacientes();
            loadEspecialidades();
            loadProfesionales();
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

                CMBProfesional.Items.Add(per.Apellido + "," + per.Nombre);
            }

        }

        private void loadPacientes()
        {
            PacienteDAO pacientes = new PacienteDAO();
            DataTable tabla = pacientes.getPacientes();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Persona per = new Persona();
                per.Nombre = (string)tabla.Rows[i][0];
                per.Apellido = (string)tabla.Rows[i][1];

                CMBAfiliado.Items.Add(per.Apellido + "," + per.Nombre);
            }

        }

        private void loadEspecialidades()
        {
            EspecialidadMedicaDAO esp = new EspecialidadMedicaDAO();
            DataTable tabla = esp.getEspecialidades();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string detalle = (string)tabla.Rows[i][0];

                CMBEspecialidades.Items.Add(detalle);
            }
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

        private void loadTurnos(string afi, string prof)
        {

            int id_afiliado = get_id_persona(afi);
            int id_profesional = get_id_persona(prof);
            DateTime fechaActual = DateTime.Now;

            RegistrarLlegadaDAO reg = new RegistrarLlegadaDAO();
            DataTable tabla = reg.turnos(id_profesional, id_afiliado, fechaActual);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Decimal turno = (Decimal)tabla.Rows[i][0];
                DateTime fecha = (DateTime)tabla.Rows[i][1];

                CMBTurno.Items.Add(turno + " - " + fecha);
            }

            if (CMBTurno.Items.Count > 0)
            {
                CMBTurno.Enabled = true;
            }
            else
            {
                MessageBox.Show("El afiliado no tiene turnos reservados", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /*** PROCEDIMIENTOS ***/
        private int get_id_persona(string persona)
        {
            RegistrarLlegadaDAO reg = new RegistrarLlegadaDAO();
            DataTable tabla = reg.get_id(persona);

            int id = (int)tabla.Rows[0][0];
            return id;
        }

        private string GetNumeroAfiliado(string p)
        {
            RegistrarLlegadaDAO respuesta = new RegistrarLlegadaDAO();
            DataTable dt = new DataTable();

            dt = respuesta.GetNumero(p);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Los datos ingresados no corresponden a un afiliado","Turnos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return "Seleccione afiliado";
            }
            else
            {
                return Convert.ToString(dt.Rows[0][0]);
            }
        }

        private void BuscarAfiliado(Int32 p)
        {
            RegistrarLlegadaDAO respuesta = new RegistrarLlegadaDAO();
            DataTable dt = new DataTable();

            dt = respuesta.GetNombre(p);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El numero de afiliado no es correcto", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CMBAfiliado.Text = (String)dt.Rows[0][0] + "," + (String)dt.Rows[0][1];
            }

        }


        /*** EVENTOS ***/
        private void CMBEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBProfesional.Text == "")
            {
                loadProfesionalesXEspecialidad(CMBEspecialidades.Text);
            }
        }

        private void CMBProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBAfiliado.Text != "Seleccione afiliado")
            {
                loadTurnos(CMBAfiliado.Text, CMBProfesional.Text);

                EspecialidadMedicaDAO especialidad = new EspecialidadMedicaDAO();

                DataTable dt = new DataTable();

                dt = especialidad.getEspecialidadesByProfesional((get_id_persona(CMBProfesional.Text)));

                CMBEspecialidades.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CMBEspecialidades.Items.Add(Convert.ToString(dt.Rows[i][0]));
                }
            }
        }

        private void CMBAfiliado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBEspecialidades.Enabled = true;
            CMBProfesional.Enabled = true;
            txtNumeroAfiliado.Text = GetNumeroAfiliado(CMBAfiliado.Text);
        }

        private void CMBTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMBProfesional.Enabled = false;
            CMBAfiliado.Enabled = false;
        }

        private void txtNumeroAfiliado_Enter(object sender, EventArgs e)
        {
            txtNumeroAfiliado.SelectAll();
        }

        private void txtNumeroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if ((!char.IsDigit(caracter)) && (caracter != 8)) // el numero 8 representa al BACKSPACE en el codigo ASCII
            {
                e.Handled = true;
            }
            if (caracter == Convert.ToChar(Keys.Enter))
            {
                if (txtNumeroAfiliado.Text != "Ingrese numero de afiliado")
                {
                    BuscarAfiliado(Convert.ToInt32(txtNumeroAfiliado.Text));
                }
            }
        }

        private void txtNumeroAfiliado_Leave(object sender, EventArgs e)
        {
            if (txtNumeroAfiliado.Text != "Ingrese numero de afiliado")
            {
                BuscarAfiliado(Convert.ToInt32(txtNumeroAfiliado.Text));
            }
        }


        /*** BOTONES ***/
        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if (CMBTurno.Text != "")
            {
                Respuesta resp = new Respuesta();

                int id_afiliado = get_id_persona(CMBAfiliado.Text);
                int id_profesional = get_id_persona(CMBProfesional.Text);

                int fin = CMBTurno.Text.IndexOf("-") - 1;
                string sturno = CMBTurno.Text.Substring(0, fin);
                int turno = Int32.Parse(sturno);

                RegistrarLlegadaDAO registrarLlegadaDAO = new RegistrarLlegadaDAO();
                RegistrarLlegada afiliado = new RegistrarLlegada();
                afiliado.Id_afiliado = id_afiliado;
                afiliado.Id_profesional = id_profesional;
                afiliado.Id_turno = turno;
                afiliado.Hora_llegada = DateTime.Now;

                resp = registrarLlegadaDAO.insertarRegistrarLlegada(afiliado);

                MessageBox.Show(resp.DescripcionError, "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe elegir el turno", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}