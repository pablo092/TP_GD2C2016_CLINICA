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
    class ClienteDAO : BaseDao
    {

        /// <summary>
        /// Modificar Usuario - Cliente. 
        /// invoca a RAT.ABM_USUARIO_MODIFICAR_CLIENTE
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public Respuesta guardar( Cliente cliente )
        {
            Respuesta respuesta = new Respuesta();
            SqlCommand comando;
            try
            {
                if (cliente.Id > 0)
                {
                    comando = new SqlCommand("RAT.ABM_USUARIO_MODIFICAR_CLIENTE", conexion);

                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ID_ESTADO_USUARIO", cliente.Estado.Id);
                    comando.Parameters.AddWithValue("@LOGIN", cliente.Login);//
                }
                else
                {
                    comando = new SqlCommand("RAT.ABM_USUARIO_ALTA_CLIENTE", conexion);

                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@PASSWORD", cliente.Clave);
                    comando.Parameters.AddWithValue("@LOGIN", cliente.Login);
                    comando.Parameters.AddWithValue("@ALTA_USUARIO", Propiedades.getFechaActual);
                }

                if (cliente.NumeroDocumento.ToString().Equals(""))
                {
                    respuesta.CodigoError = 99;
                    respuesta.DescripcionError = "Debe ingresar un Numero de Documento";
                    return respuesta;
                }

                comando.Parameters.AddWithValue("@NUMERO_DOCUMENTO", Int32.Parse(cliente.NumeroDocumento.ToString()));//
                comando.Parameters.AddWithValue("@TIPO_DOCUMENTO", cliente.TipoDocumento);//
                comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);//
                comando.Parameters.AddWithValue("@APELLIDO", cliente.Apellido);//

                comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);//
                comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", DateTime.Parse( cliente.FechaNacimiento.ToShortDateString()).Date);//
                comando.Parameters.AddWithValue("@MAIL", cliente.Email);//

                comando.Parameters.AddWithValue("@DOM_CALLE", cliente.Direccion.Calle);

                if (cliente.Direccion.Numero == null)
                {
                    comando.Parameters.AddWithValue("@NRO_CALLE", DBNull.Value);
                }
                else {
                    comando.Parameters.AddWithValue("@NRO_CALLE", cliente.Direccion.Numero);
                }
                if (cliente.Direccion.Piso == null)
                {
                    comando.Parameters.AddWithValue("@PISO", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@PISO", cliente.Direccion.Piso);
                }
                comando.Parameters.AddWithValue("@DEPTO", cliente.Direccion.Departamento);
                comando.Parameters.AddWithValue("@LOCALIDAD", cliente.Direccion.Localidad);
                comando.Parameters.AddWithValue("@COD_POSTAL", cliente.Direccion.CodigoPostal);

                

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                comando.ExecuteNonQuery();  // Ejecuta el sp

                respuesta.CodigoError = (int)valorRetorno1.Value;
                respuesta.DescripcionError = valorRetorno2.Value.ToString();

                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.CodigoError = 99;
                respuesta.DescripcionError = "Error crítico: " + ex.Message.ToString() ;
                return respuesta;
                //  throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Filtra los Usuario - Cliente por nombre, apellido, mail, documento, tipo documento. 
        /// invoca a RAT.GET_CLIENTES_POR_DESCRIPCION
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public Respuesta getClientes(Cliente cliente)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                SqlCommand comando = new SqlCommand("RAT.GET_CLIENTES_POR_DESCRIPCION", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", cliente.Apellido);
                comando.Parameters.AddWithValue("@EMAIL", cliente.Email);
                if (cliente.IdTipoDocumento == null || cliente.IdTipoDocumento == 0)
                {
                    comando.Parameters.AddWithValue("@ID_TIPO_DNI", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@ID_TIPO_DNI", cliente.IdTipoDocumento);
                }
                
                if (cliente.NumeroDocumento == 0)
                {
                    comando.Parameters.AddWithValue("@DNI",  DBNull.Value );
                }
                else
                {
                    comando.Parameters.AddWithValue("@DNI", cliente.NumeroDocumento);
                }

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
               
    }
}
