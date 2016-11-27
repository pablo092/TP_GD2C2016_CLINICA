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
    class EspecialidadMedicaDAO : BaseDao
    {
        public EspecialidadMedicaDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public EspecialidadMedicaDAO(SqlConnection con)
        {
            conexion = con;
        }

      
        public DataTable getEspecialidades(SqlTransaction tran = null)
        {
            DataTable respuesta = new DataTable();

            SqlCommand comando = new SqlCommand("SELECT DETALLE FROM FLOPANICMA.ESPECIALIDAD", conexion);
            comando.Transaction = tran;

            try
            {
                comando.CommandType = CommandType.Text;

                SqlDataReader reader = comando.ExecuteReader();

                respuesta.Load(reader);

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (tran == null)
                {
                    conexion.Close();
                }

            }
        }

        public DataTable getAllEspecialidades(SqlTransaction tran = null)
        {
            DataTable respuesta = new DataTable();

            SqlCommand comando = new SqlCommand("SELECT DISTINCT TESP.DETALLE AS 'TIPO ESPECIALIDAD', " + 
                                                "ESP.DETALLE AS 'ESPECIALIDAD', PER.NOMBRE, PER.APELLIDO " +  
                                                "FROM FLOPANICMA.ESPECIALIDAD AS ESP JOIN " +
                                                "FLOPANICMA.TIPO_ESPECIALIDAD AS TESP " +
                                                "ON ESP.ID_TIPO_ESPECIALIDAD = TESP.ID_TIPO_ESPECIALIDAD " +
                                                "JOIN FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESP_PROF " +
                                                "ON ESP_PROF.ID_ESPECIALIDAD = ESP.ID_ESPECIALIDAD " +
                                                "JOIN FLOPANICMA.PERSONA AS PER " +
                                                "ON ESP_PROF.ID_PROFESIONAL = PER.ID_PERSONA " +
                                                "ORDER BY ESP.DETALLE ASC", conexion);
            comando.Transaction = tran;

            try
            {
                comando.CommandType = CommandType.Text;

                SqlDataReader reader = comando.ExecuteReader();

                respuesta.Load(reader);

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (tran == null)
                {
                    conexion.Close();
                }

            }
        }

        public DataTable getEspecialidadesByProfesional(int idProf, SqlTransaction tran = null)
        {
            DataTable respuesta = new DataTable();

            SqlCommand comando = new SqlCommand("SELECT DETALLE FROM " +
                                                "FLOPANICMA.ESPECIALIDAD AS ESP " +
                                                "JOIN FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESP_PROF " + 
                                                "ON ESP.ID_ESPECIALIDAD = ESP_PROF.ID_ESPECIALIDAD " + 
                                                "WHERE ID_PROFESIONAL = @ID_PROFESIONAL", conexion);
            comando.Transaction = tran;

            try
            {
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@ID_PROFESIONAL", idProf);

                SqlDataReader reader = comando.ExecuteReader();

                respuesta.Load(reader);

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (tran == null)
                {
                    conexion.Close();
                }

            }
        }
    }
}
