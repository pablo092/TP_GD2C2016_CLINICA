using ClinicaFrba.Common;
using ClinicaFrba.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class AgendaDAO : BaseDao 
    {
        public AgendaDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public AgendaDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Invoca a FLOPANICMA.SP_REGISTRAR_AGENDA para ingresar la agenda
        /// </summary>
        /// <param name="con"></param>
        public Respuesta insertarAgenda(Agenda agenda)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRAR_AGENDA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_PROFESIONAL", agenda.IdProf);
                comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", agenda.IdEsp);
                comando.Parameters.AddWithValue("@FECHA", agenda.Fecha);
                comando.Parameters.AddWithValue("@HORA_INICIO", agenda.HoraInicio);
                comando.Parameters.AddWithValue("@HORA_FIN", agenda.HoraFin);
                comando.Parameters.AddWithValue("@PERIODO_INICIO", agenda.PeriodoInicio);
                comando.Parameters.AddWithValue("@PERIODO_FIN", agenda.PeriodoFin);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@MENSAJE", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();  // Ejecuta el sp

                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = valorRetorno2.Value.ToString();

                return resultadoSP;
            }
            catch (Exception ex)
            {
                resultadoSP.CodigoError = 99;
                resultadoSP.DescripcionError = "Error Fatal: " + ex.Message;
                return resultadoSP;
            }
        }
    }
}
