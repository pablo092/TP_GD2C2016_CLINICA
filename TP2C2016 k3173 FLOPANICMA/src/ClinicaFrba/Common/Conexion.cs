using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ClinicaFrba.Common;

namespace Clinica.Common
{
    public static class Conexion
    {
        private static SqlConnection conex = null;
                
        /// <summary>
        /// Retorna nuna nueva conexion. La misma debe ser cerrada luego de ser utilizada.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConexion()
        {            
            if (conex == null || conex.State == ConnectionState.Closed)
            {
                String str = Propiedades.getStringConexion();
                conex = new SqlConnection();
                conex.ConnectionString = str;
                conex.Open();
            }
            return conex;
        }
    }
}
