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
