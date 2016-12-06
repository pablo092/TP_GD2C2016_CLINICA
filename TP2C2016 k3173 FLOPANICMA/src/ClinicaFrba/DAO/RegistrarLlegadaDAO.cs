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

        public DataTable GetNumero(String afiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();
      
            try
            {
                SqlCommand comando = new SqlCommand("SELECT AFI.NRO_AFILIADO FROM FLOPANICMA.PERSONA AS PER JOIN " +
                                                "FLOPANICMA.AFILIADO AS AFI ON PER.ID_PERSONA = AFI.ID_AFILIADO " +
                                                "WHERE APELLIDO + ',' + NOMBRE = @AFILIADO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@AFILIADO", afiliado);

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


        public DataTable GetNombre(int numero_afiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();
 
            try
            {
                SqlCommand comando = new SqlCommand("SELECT APELLIDO,NOMBRE FROM FLOPANICMA.PERSONA AS PER JOIN " +
                                                "FLOPANICMA.AFILIADO AS AFI ON PER.ID_PERSONA = AFI.ID_AFILIADO " +
                                                "WHERE NRO_AFILIADO = @AFILIADO", conexion);

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
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.PERSONA " +
                                                "WHERE APELLIDO + ','+NOMBRE = @PERSONA", conexion);

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
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRAR_LLEGADA_ATENCION_MEDICA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_PROFESIONAL", reg.Id_profesional);
                comando.Parameters.AddWithValue("@ID_AFILIADO", reg.Id_afiliado);
                comando.Parameters.AddWithValue("@ID_TURNO", reg.Id_turno);
                comando.Parameters.AddWithValue("@FECHA", reg.Hora_llegada);
                
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

        public DataTable turnos(int id_profesional, int id_afiliado, DateTime fechaActual)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();
            DateTime inicio = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 0, 0, 0);
            DateTime fin = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 23, 59, 0);
            
            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_TURNO,FECHA FROM FLOPANICMA.PEDIDO_TURNO " +
                                                "WHERE ID_PROFESIONAL = @PROFESIONAL AND ID_AFILIADO = @AFILIADO " +
                                                "AND ID_TURNO NOT IN (SELECT ID_TURNO FROM FLOPANICMA.CONSULTA) AND "+
                                                "FECHA BETWEEN @INICIO AND @FIN ", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@PROFESIONAL", id_profesional);
                comando.Parameters.AddWithValue("@AFILIADO", id_afiliado);
                comando.Parameters.AddWithValue("@INICIO", inicio);
                comando.Parameters.AddWithValue("@FIN", fin);

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
    }
}