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

namespace ClinicaFrba.AdministradorDao
{
    class AdministradorAfiliado
    {
        public Respuesta insertaAfiliado(Afiliado afiliado)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new AfiliadoDAO(conn).ingresarAfiliado(afiliado);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Respuesta modificarAfiliado(Afiliado afiliado)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new AfiliadoDAO(conn).modificarAfiliado(afiliado);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Respuesta darBajaAfiliado(Afiliado afiliado)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new AfiliadoDAO(conn).darBajaAfiliado(afiliado);
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
