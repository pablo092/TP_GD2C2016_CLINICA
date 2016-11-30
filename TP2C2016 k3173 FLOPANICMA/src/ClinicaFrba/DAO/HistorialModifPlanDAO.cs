using ClinicaFrba.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class HistorialModifPlanDAO : BaseDao
    {
        public HistorialModifPlanDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public HistorialModifPlanDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Invoca a FLOPANICMA.SP_HISTORIAL_MODIF_PLAN para obtener el historial de modificaciones del afiliado
        /// </summary>
        /// <param name="nroAfiliado"></param>
        public DataTable getHistModifByNroAfil(int nroAfiliado)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_HISTORIAL_MODIF_PLAN", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@NRO_AFILIADO", nroAfiliado);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@MENSAJE", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                SqlDataReader reader = comando.ExecuteReader();
                dt.Load(reader);

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
