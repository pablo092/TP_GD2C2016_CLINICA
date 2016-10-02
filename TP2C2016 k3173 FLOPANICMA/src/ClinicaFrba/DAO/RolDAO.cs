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
    class RolDAO : BaseDao
    {
        public RolDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        public RolDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Inserta un rol nuevo
        /// invoca a RAT.ABM_ROL_ALTA
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public Respuesta insertaRol(Rol rol, SqlTransaction tran = null )
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.ABM_ROL_ALTA", conexion);
                if (tran != null)
                {
                    comando.Transaction = tran;
                }
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", rol.Descripcion);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();  // Ejecuta el sp

                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = valorRetorno2.Value.ToString();

                return resultadoSP;
            }
            catch (Exception ex)
            {
                resultadoSP.CodigoError = 99;
                resultadoSP.DescripcionError = "Error Fatal: " + ex.Message;
                return resultadoSP;
            }
        }

        /// <summary>
        /// Desasocia tods las funcionalidades de un rol. 
        /// invoca a RAT.ABM_ROL_QUITAR_TODAS_LAS_FUNCIONALIDADES
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public Respuesta limpiarFuncionalidad(Rol rol, SqlTransaction tran = null)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.ABM_ROL_QUITAR_TODAS_LAS_FUNCIONALIDADES", conexion);
                comando.Transaction = tran;
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", rol.Descripcion);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();  // Ejecuta el sp

                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = valorRetorno2.Value.ToString();

                return resultadoSP;
            }
            catch (Exception ex)
            {
                resultadoSP.CodigoError = 99;
                resultadoSP.DescripcionError = "Error Fatal: " + ex.Message;
                return resultadoSP;
            }

        }

        /// <summary>
        /// Desasocia un rol de un usuario. 
        /// invoca a RAT.ABM_USUARIO_ELIMINAR_ROL
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rol"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public Respuesta eliminarRolInUsername(String username, String rol, SqlTransaction tran = null)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.ABM_USUARIO_ELIMINAR_ROL", conexion);
                if (tran != null)
                {
                    comando.Transaction = tran;
                }
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@LOGIN", username);
                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", rol);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery(); 

                respuesta.CodigoError = (int)valorRetorno1.Value;
                respuesta.DescripcionError = valorRetorno2.Value.ToString();
                
                return respuesta;
                
            }
            catch (Exception ex)
            {
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error Fatal: " + ex.Message;
                return respuesta;
            }
            finally
            {
                if (tran == null)
                {
                    conexion.Close();
                }
            }
            

        }

        /// <summary>
        /// Asocia una funcionalidad a un rol. invoca a RAT.ABM_ROL_AGREGAR_FUNCIONALIDAD
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="funcionalidad"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public Respuesta insertaRolFuncionalidad(Rol rol, Funcionalidad funcionalidad, SqlTransaction tran = null)
        {
            Respuesta respuesta = new Respuesta();
            
            try
            {
                SqlCommand comando = new SqlCommand("RAT.ABM_ROL_AGREGAR_FUNCIONALIDAD", conexion);
                comando.Transaction = tran;
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", rol.Descripcion);
                comando.Parameters.AddWithValue("@DESCRIPCION_FUNCIONALIDAD", funcionalidad.Descripcion);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();

                respuesta.CodigoError = (int)valorRetorno1.Value;

                respuesta.DescripcionError = valorRetorno2.Value.ToString();

                return respuesta;

            }
            catch (Exception ex)
            {
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error Fatal!:" + ex.Message;
                return respuesta;
            }
        }

        /// <summary>
        /// Recupera todos los roles de un usuario. invoca a RAT.GET_ROLES_POR_USUARIO
        /// </summary>
        /// <param name="username"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public Respuesta getRolesByUsername(String username, SqlTransaction tran = null)
        {
            Respuesta respuesta = new Respuesta();
            
            SqlCommand comando = new SqlCommand("RAT.GET_ROLES_POR_USUARIO", conexion);
            comando.Transaction = tran;
            
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.AddWithValue("@LOGIN", username);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                SqlDataReader reader = comando.ExecuteReader();
               
                respuesta.Resultado = new DataTable();
                respuesta.Resultado.Load(reader);
                
                respuesta.CodigoError = (int)valorRetorno1.Value;

                respuesta.DescripcionError = valorRetorno2.Value.ToString();
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error Fatal: " + ex.Message.ToString();
                return respuesta;
            }
            finally
            {
                if (tran == null)
                {
                    conexion.Close();
                }
                
            }
        }

        /// <summary>
        /// Recupera una lista de roles por su descripcion. invoca a RAT.GET_ROLES_POR_DESCRIPCION
        /// </summary>
        /// <param name="descripcionRol"></param>
        /// <returns></returns>
        public Respuesta getRolByDescripcion(String descripcionRol)
        {
            DataTable dt = new DataTable();
            Respuesta respuesta = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.GET_ROLES_POR_DESCRIPCION", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", descripcionRol.ToUpper().Trim());

                SqlDataReader reader = comando.ExecuteReader();
                respuesta.Resultado = new DataTable();
                respuesta.Resultado.Load(reader);

                respuesta.CodigoError = 0;
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error Fatal!: " + ex.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Permite modificar un rol existente. invoca a RAT.ABM_ROL_MODIFICAR
        /// </summary>
        /// <param name="rol"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        internal Respuesta updateRol(Rol rol, SqlTransaction tran = null)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.ABM_ROL_MODIFICAR", conexion);
                comando.Transaction = tran;
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ID_ROL", rol.Id);
                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", rol.Descripcion);
                comando.Parameters.AddWithValue("@ID_ESTADO", rol.EstaHabilitado ? 1 : 2);

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();  // Ejecuta el sp

                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = valorRetorno2.Value.ToString();

                return resultadoSP;
            }
            catch (Exception ex)
            {
                resultadoSP.CodigoError = 99;
                resultadoSP.DescripcionError = "Error Fatal: " + ex.Message;
                return resultadoSP;
            }
        }
    }

}
