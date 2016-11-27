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
    class RegistrarAtencionDAO : BaseDao
    {
        public RegistrarAtencionDAO(SqlConnection con)
        {
            conexion = con;
        }

        public RegistrarAtencionDAO()
        {
          
        }

        public DataTable turnos(int prof, int afi, DateTime fecha)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT ID_TURNO,FECHA FROM FLOPANICMA.PEDIDO_TURNO " +
                                                "WHERE ID_AFILIADO = @AFILIADO AND ID_PROFESIONAL = @PROFESIONAL AND FECHA = @FECHA",conexion);

            try
            {
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@PROFESIONAL", prof);
                comando.Parameters.AddWithValue("@AFILIADO", afi);
                comando.Parameters.AddWithValue("@FECHA", fecha);

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

        ///Invocar a FLOPANICMA.SP_REGISTRAR_LLEGADA_ATENCION_MEDICA
        ///
        public Respuesta insertarRegistroAtencion(RegistrarAtencion registroAtencion)
        {
            Respuesta resultadoSP = new Respuesta();
       
            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRO_RESULTADO_ATENCION_MEDICA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_PEDIDO", registroAtencion.Id_pedido);
                comando.Parameters.AddWithValue("@SINTOMA", registroAtencion.Sintoma);
                comando.Parameters.AddWithValue("@DIAGNOSTICO", registroAtencion.Diagnostico);
               

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
