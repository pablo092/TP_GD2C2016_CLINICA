using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class AfiliadoDAO : BaseDao
    {
        public AfiliadoDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public AfiliadoDAO(SqlConnection con)
        {
            conexion = con;
        }
    }
}
