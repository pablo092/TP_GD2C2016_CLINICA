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

        public Decimal turnos(int prof, int afi)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);
            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_TURNO FROM FLOPANICMA.PEDIDO_TURNO " +
                                               "WHERE ID_AFILIADO = @AFILIADO AND ID_PROFESIONAL = @PROFESIONAL AND FECHA BETWEEN "+
                                               "@INICIO AND @FIN", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@PROFESIONAL", prof);
                comando.Parameters.AddWithValue("@AFILIADO", afi);
                comando.Parameters.AddWithValue("@INICIO", inicio);
                comando.Parameters.AddWithValue("@FIN",fin);

                return Convert.ToDecimal(comando.ExecuteScalar());
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
        public void insertarRegistroAtencion(RegistrarAtencion registroAtencion)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRO_RESULTADO_ATENCION_MEDICA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_TURNO", registroAtencion.Id_pedido);
                comando.Parameters.AddWithValue("@SINTOMA", registroAtencion.Sintoma);
                comando.Parameters.AddWithValue("@DIAGNOSTICO", registroAtencion.Diagnostico);
                comando.Parameters.AddWithValue("@HORA_ATENCION", registroAtencion.Fecha);

                comando.ExecuteNonQuery();  // Ejecuta el sp

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
