using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinica.Common;
using ClinicaFrba.Common;
using ClinicaFrba.DAO;
using ClinicaFrba.DTO;

namespace ClinicaFrba.AdministradorDao
{
    class AdministradorRol
    {
        public Respuesta insertaRol( Rol rol )
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new RolDAO(conn).insertaRol(rol);
            }
            finally 
            {
                if (conn != null) {
                    conn.Close();
                }
            }
        }

        public Respuesta actualizaRol(Rol rol)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new RolDAO(conn).updateRol(rol);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Respuesta modificarRol(Rol rol)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                return new RolDAO(conn).modificarEstadoRol(rol);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Respuesta limpiarFuncionalidades(Rol rol)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                RolDAO rolDao = new RolDAO(conn);
                resp = rolDao.limpiarFuncionalidad(rol);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return resp;
        }
        public Respuesta guardarFuncionalidad(Rol rol, List<Funcionalidad> funcionalidades)
        {
            Respuesta resp = new Respuesta();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.getConexion();
                SqlTransaction transaction = conn.BeginTransaction();
             
                RolDAO rolDao = new RolDAO(conn);
                foreach( Funcionalidad funcionalidad in funcionalidades )
                {
                    resp = rolDao.insertaRolFuncionalidad(rol, funcionalidad, transaction);
                    if ( resp.CodigoError > 0 )
                    {
                        transaction.Rollback();
                        return resp;
                    }
                }
                transaction.Commit();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return resp;
        }

        public Respuesta guardarRolFuncionalidad(Rol rol, List<Funcionalidad> funcionalidades)
        {
            Respuesta resp = new Respuesta();
            if (!(rol.Id > 0))
            {
                resp = insertaRol(rol);
            }
            else
            {
                resp = actualizaRol(rol);
                if (resp.CodigoError > 0)
                {
                    return resp;
                }
                //Limpio las funcionalidades para insertar solo las que se seleccionaron
                resp = limpiarFuncionalidades(rol);
            }
            
            if (resp.CodigoError > 0)
            {
                return resp;
            }
            
            resp = guardarFuncionalidad(rol, funcionalidades);

            if (resp.CodigoError > 0)
            {
                resp.CodigoError = 99;
                resp.DescripcionError = "Rol insertado, no se pudo insertar las funcionalidades!";
                return resp;
            }
            return resp;
        }
    }
}
