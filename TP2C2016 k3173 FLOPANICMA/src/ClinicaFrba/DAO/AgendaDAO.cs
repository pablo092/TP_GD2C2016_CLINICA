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
        public int GetIdProfesional(String profesional)
        {
            int respuesta = new int();
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.PERSONA " +
                                               "WHERE APELLIDO +','+ NOMBRE = @PROFESIONAL", conexion);

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("Profesional", profesional);
            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);
                
                respuesta =(int) dt.Rows[0][0];

                return respuesta;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }


        public Decimal GetIdEspecialidad(string especialidad)
        {
            conexion.Open();
            Decimal respuesta = new Decimal();
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT ID_ESPECIALIDAD FROM FLOPANICMA.ESPECIALIDAD " +
                                                "WHERE DETALLE = @ESPECIALIDAD", conexion);

            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);

            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                respuesta = (Decimal)dt.Rows[0][0];

                return respuesta;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }

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
                conexion.Open();

                
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRAR_AGENDA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_PROFESIONAL", agenda.IdProf);
                comando.Parameters.AddWithValue("@DIA", agenda.Dia);
                comando.Parameters.AddWithValue("@ID_ESPECIALIDAD",agenda.IdEsp);
                comando.Parameters.AddWithValue("@INICIO", agenda.HoraInicio);
                comando.Parameters.AddWithValue("@FIN", agenda.HoraFin);
                comando.Parameters.AddWithValue("@PERIODO_INICIO", agenda.PeriodoInicio);
                comando.Parameters.AddWithValue("@PERIODO_FIN", agenda.PeriodoFin);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(Int32);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@MENSAJE", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                Int32 filasafectadas = comando.ExecuteNonQuery();  // Ejecuta el sp
                
                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = (String)valorRetorno2.Value;

                return resultadoSP;
               
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
            finally
            {
                conexion.Close();
            }

        }
    }
}
