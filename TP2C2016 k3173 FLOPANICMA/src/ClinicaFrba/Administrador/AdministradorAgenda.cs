using Clinica.Common;
using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Administrador
{
    class AdministradorAgenda
    {
        public Respuesta insertaAgenda(Agenda agenda)
        {
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new AgendaDAO(conn).insertarAgenda(agenda);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
