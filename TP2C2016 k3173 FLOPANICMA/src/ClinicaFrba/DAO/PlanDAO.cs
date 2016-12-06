using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class PlanDAO : BaseDao
    {
        public PlanDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public PlanDAO(SqlConnection con)
        {
            conexion = con;
        }

        public DataTable getPlanes()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT DESCRIPCION,CUOTA,COSTO_CONSULTA,COSTO_FARMACIA " +
                                                    "FROM FLOPANICMA.PLAN_MEDICO", conexion);

                comando.CommandType = CommandType.Text;

                dt.Load(comando.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        internal decimal GetIdPlanPorDescripcion(string detalle)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PLAN FROM FLOPANICMA.PLAN_MEDICO " +
                                                    "WHERE DESCRIPCION = @DETALLE", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@DETALLE", detalle);

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
    }
}
