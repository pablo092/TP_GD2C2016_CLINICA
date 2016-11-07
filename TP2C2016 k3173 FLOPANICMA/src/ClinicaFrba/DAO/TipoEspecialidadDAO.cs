using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class TipoEspecialidadDAO:BaseDao
    {
        public TipoEspecialidadDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public TipoEspecialidadDAO(SqlConnection con)
        {
            conexion = con;
        }

        public DataTable getAllTipoEspecialidades()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM FLOPANICMA.TIPO_ESPECIALIDAD ORDER BY 1 ASC", conexion);

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
