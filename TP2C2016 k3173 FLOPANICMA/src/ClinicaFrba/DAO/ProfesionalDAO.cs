using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class ProfesionalDAO : BaseDao
    {
        public ProfesionalDAO()
        {

        }

        public ProfesionalDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Recupera una lista de todos los profesionales. 
        /// </summary>
        /// <returns></returns>

        public DataTable getProfesionalesXEspecialidad(string esp)
        {
            DataTable dt = new DataTable();

            SqlCommand comando = new SqlCommand("SELECT PERTAB.NOMBRE, PERTAB.APELLIDO " +
                                                   "FROM FLOPANICMA.PERSONA AS PERTAB JOIN " +
                                                   "FLOPANICMA.PROFESIONAL AS PROTAB ON PERTAB.ID_PERSONA = PROTAB.ID_PROFESIONAL JOIN " +
                                                   "FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESPPROTAB ON PROTAB.ID_PROFESIONAL = ESPPROTAB.ID_PROFESIONAL JOIN " +
                                                   "FLOPANICMA.ESPECIALIDAD AS ESPTAB ON ESPPROTAB.ID_ESPECIALIDAD=ESPTAB.ID_ESPECIALIDAD " +
                                                   "WHERE ESPTAB.DETALLE = @ESPECIALIDAD", conexion);
            try
            {
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ESPECIALIDAD", esp);

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


        public DataTable getProfesionales()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PROFESIONAL, NOMBRE, APELLIDO " +
                                                    "FROM FLOPANICMA.PERSONA " + 
                                                    "JOIN FLOPANICMA.PROFESIONAL ON " + 
                                                    "ID_PERSONA = ID_PROFESIONAL", conexion);

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
    }
}
