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
    class RegistrarLlegadaDAO : BaseDao
    {
        public RegistrarLlegadaDAO()
        {

        }


        public DataTable GetNombre(int numero_afiliado)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT APELLIDO,NOMBRE FROM FLOPANICMA.PERSONA AS PER JOIN " +
                                                "AFILIADO AS AFI ON PER.ID_PERSONA = AFI.ID_AFILIADO " +
                                                "WHERE NRO_AFILIADO = @AFILIADO", conexion);

            try
            {
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@AFILIADO", numero_afiliado);

                dt.Load(comando.ExecuteReader());

                return dt;
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
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public RegistrarLlegadaDAO(SqlConnection con)
        {
            conexion = con;
        }

        public DataTable get_id(string per)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.PERSONA " +
                                                "WHERE APELLIDO + ','+NOMBRE = @PERSONA", conexion);

            try
            {
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@PERSONA", per);

                dt.Load(comando.ExecuteReader());

                return dt;
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
        /// Invoca a FLOPANICMA.SP_REGISTRAR_LLEGADA_ATENCION_MEDICA para la recepcion y validacion del afiliado
        /// </summary>
        /// <param name="con"></param>
        public Respuesta insertarRegistrarLlegada(RegistrarLlegada reg)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRAR_LLEGADA_ATENCION_MEDICA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_PROFESIONAL", reg.Id_profesional);
                comando.Parameters.AddWithValue("@ID_AFILIADO", reg.Id_afiliado);
                comando.Parameters.AddWithValue("@ID_TURNO", reg.Id_turno);
                comando.Parameters.AddWithValue("@HORA", reg.Hora_llegada);
                
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