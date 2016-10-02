using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Clinica.Common;
using ClinicaFrba.Common;
using ClinicaFrba.DTO;

namespace ClinicaFrba.DAO
{
    /// <summary>
    /// Toda DAO debe extender de esta clase, esto hará que al llamar al constructor vacío, se cree una nueva conexión.
    /// Siempre que se invoque a un método de la DAO, se deberá crear una nueva invocación a su constructor vacío.
    /// Cada método de la DAO tiene la responsabilidad de cerrar su conexión.
    /// </summary>
    class BaseDao
    {
        protected SqlConnection conexion;
        
        public BaseDao()
        {
            conexion = Conexion.getConexion();
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        
    }
}
