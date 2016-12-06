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
    class UsuarioDAO : BaseDao
    {
        /// <summary>
        /// Valida el user y pass ingresados. 
        /// Actualiza la cantidad de intentos en caso de fallo.
        /// Invoca a FLOPANICMA.LOGIN_USUARIO
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Respuesta credencialValida(Usuario usuario)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.LOGIN_USUARIO", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@USERNAME", usuario.Username);
                comando.Parameters.AddWithValue("@PASSWORD", usuario.Clave);

                SqlParameter idUsuario = new SqlParameter("@ID_USUARIO", SqlDbType.Int);
                idUsuario.Size = sizeof(int);
                idUsuario.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idUsuario);

                SqlParameter valorRetorno1 = new SqlParameter("@ID_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();

                respuesta.ParametroAdicional = (int)idUsuario.Value;
                respuesta.CodigoError = (int)valorRetorno1.Value;

                respuesta.DescripcionError = valorRetorno2.Value.ToString();

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
            return respuesta;
        }

        /// <summary>
        /// Valida si una password corresponde con un usuario. 
        /// Esto debe utilizarse sólamente para el cambio de password propio, en caso contrario usar credencialValida
        /// </summary>
        /// <param name="pass"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public Boolean passwordValida(String pass) 
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            SqlDataReader reader = null;

            try
            {
                Boolean esValida = false;

                SqlCommand cmd =
                    new SqlCommand("SELECT 1 FROM FLOPANICMA.USUARIO WHERE PASSWORD = FLOPANICMA.PASSWORD_HASH(@Pass) AND USERNAME = @USERNAME", conexion);
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = pass;
                cmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = UsuarioLogueado.usuario.Username;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    {
                        while (reader.Read())
                        {
                            esValida = true;
                        }
                    }
                }
                return esValida;
            }
            finally {
                conexion.Close();
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// Agrega roles a un usuario. Se debe usar junto con el alta/modificacion de clientes/empresas. 
        /// Invoca a ABM_USUARIO_AGREGAR_ROL
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Respuesta guardar(Usuario usuario)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta();
            SqlTransaction transaction = conexion.BeginTransaction();
            try
            {
                if (usuario.Id > 0)
                {
                    Usuario usuarioAux = getUsuarioPorUsername(usuario.Username, transaction);
                    usuario.Id = usuarioAux.Id;
                    if (usuario.Username.Equals(""))
                    {
                        usuario.Username = usuarioAux.Username;
                    }

                    if (usuario.Rol == null || usuario.Rol.Descripcion.Equals(""))
                    {
                        usuario.Rol = usuarioAux.Rol;
                    }
                }

                RolDAO rolDao = new RolDAO();
                Respuesta respuestaRol = rolDao.getRolesByUsername(usuario.Username, transaction);
                //El usuario tiene roles asignados, entonces los elimino.
                if (respuestaRol.CodigoError == 0)
                {
                    foreach (DataRow rol in respuestaRol.Resultado.Rows)
                    {
                        Respuesta rEliminar = rolDao.eliminarRolInUsername(usuario.Username, (String)rol[1], transaction);
                        if (rEliminar.CodigoError > 0)
                        {
                            new Exception();
                        }
                    }

                }

                //Agrego el rol seleccionado
                SqlCommand comando = new SqlCommand("FLOPANICMA.ABM_USUARIO_AGREGAR_ROL", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Transaction = transaction;

                comando.Parameters.AddWithValue("@LOGIN", usuario.Username);
                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", usuario.Rol.Descripcion);

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

                if (respuesta.CodigoError > 0)
                {
                    transaction.Rollback();
                    return respuesta;
                }
                else
                {
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error Fatal!: " + ex.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        /// <summary>
        /// Obtiene un usuario accediendo directamente a la DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public Usuario getUsuarioPorUsername(String username, SqlTransaction transaction = null)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }


            String sql = "SELECT U.ID_USUARIO, U.ID_ESTADO AS ESTADO_USUARIO, RO.ID_ROL, RO.DESCRIPCION AS ROL " +
                        "FROM FLOPANICMA.USUARIO U, FLOPANICMA.USUARIO_ROL UR, FLOPANICMA.ROL RO " +
                        "WHERE U.ID_USUARIO = UR.ID_USUARIO " +
                        "AND UR.ID_ROL = RO.ID_ROL " +
                        "AND U.LOGIN = '" + username + "'";


            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            Usuario usuario = new Usuario();

            try
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                if (transaction != null)
                {
                    cmd.Transaction = transaction;
                }

                cmd.Connection = conexion;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    {
                        while (reader.Read())
                        {
                            usuario.Id = reader.GetInt32(0);
                            usuario.Username = username;
                            Rol rol = new Rol();
                            String descRol = reader.GetString(3);
                            if (descRol != null && !descRol.Equals(""))
                            {
                                rol.Id = reader.GetInt32(2);
                                rol.Descripcion = descRol;
                                usuario.Rol = rol;
                            }
                        }
                    }
                }
                reader.Close();
                return usuario;
            }
            finally
            {
                if (transaction == null)
                {
                    conexion.Close();
                }
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }      
        }

        /// <summary>
        /// Filtra los usuarios por username, y los devuelve en una lista. Invoca a GET_USUARIOS_POR_USERNAME
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Respuesta getListaUsuariosByUsername(String username)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.GET_USUARIOS_POR_USERNAME", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@USERNAME", username);

                SqlDataReader reader = comando.ExecuteReader();

                respuesta.Resultado = new DataTable();
                respuesta.Resultado.Load(reader);

                respuesta.CodigoError = 0;
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
            return respuesta;

        }
        
        /// <summary>
        /// Actualiza la pass de un user
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Respuesta actualizarClave(Usuario usuario)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta();

            
            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.MODIFICAR_PASSWORD", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID_USUARIO", usuario.Id);
                comando.Parameters.AddWithValue("@PASS_NUEVA", usuario.Clave);


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
            return respuesta;

        }

        /// <summary>
        /// Actualiza la pass del usuario actual.
        /// </summary>
        /// <param name="p"></param>
        internal void actualizarPassword(string pass)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE FLOPANICMA.USUARIO SET PASSWORD = FLOPANICMA.PASSWORD_HASH (@PASS) WHERE USERNAME = @LOGIN", conexion);
                cmd.Parameters.Add("@PASS", SqlDbType.NVarChar).Value = pass;
                cmd.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = UsuarioLogueado.usuario.Username;
                
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Habilita / dshabilita un usuario
        /// </summary>
        /// <param name="usuario"></param>
        internal void actualizarEstadoUsuario(Usuario usuario)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE FLOPANICMA.USUARIO SET ID_ESTADO = @IDESTADO WHERE USERNAME = @LOGIN", conexion);
                cmd.Parameters.Add("IDESTADO", SqlDbType.NVarChar).Value = usuario.Estado.Id;
                cmd.Parameters.Add("LOGIN", SqlDbType.NVarChar).Value = usuario.Username;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
