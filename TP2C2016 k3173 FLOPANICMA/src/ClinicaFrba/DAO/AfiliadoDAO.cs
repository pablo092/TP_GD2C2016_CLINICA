using ClinicaFrba.Common;
using ClinicaFrba.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Invoca a FLOPANICMA.SP_GET_AFILIADO_PARA_MODIF para editar un afiliado
        /// </summary>
        /// <param name="con"></param>
        public Respuesta getAfiliadoByDescripcion(int nroAfiliado)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_GET_AFILIADO_PARA_MODIF", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@NRO_AFILIADO", nroAfiliado);

                SqlParameter valorRetorno1 = new SqlParameter("@ID_ERROR", SqlDbType.Int);
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
        /// Invoca a FLOPANICMA.SP_AFILIADO_RAIZ_ALTA para registrar al afiliado
        /// </summary>
        /// <param name="afiliado"></param>
        public Respuesta ingresarAfiliado(Afiliado afiliado)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_AFILIADO_RAIZ_ALTA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@NOMBRE", afiliado.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO", afiliado.Apellido);
                comando.Parameters.AddWithValue("@TIPO_DOCUMENTO", afiliado.TipoDocumento);
                comando.Parameters.AddWithValue("@NRO_DOCUMENTO", afiliado.NumeroDocumento);
                comando.Parameters.AddWithValue("@SEXO", afiliado.Sexo);
                comando.Parameters.AddWithValue("@DIRECCION", afiliado.Direccion);
                comando.Parameters.AddWithValue("@TELEFONO", afiliado.Telefono);
                comando.Parameters.AddWithValue("@E_MAIL", afiliado.Email);
                comando.Parameters.AddWithValue("@F_NACIMIENTO", afiliado.FechaNacimiento);
                comando.Parameters.AddWithValue("@ESTADO_CIVIL", afiliado.EstadoCivil);
                comando.Parameters.AddWithValue("@PLAN_MEDICO", afiliado.PlanMedicoActual);
                comando.Parameters.AddWithValue("@CANTIDAD_HIJOS", afiliado.CantHijos);
                comando.Parameters.AddWithValue("@ID_PERSONA", afiliado.Id);


                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@MENSAJE", SqlDbType.VarChar);
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
        /// Invoca a FLOPANICMA.SP_AFILIADO_MODIFICACION para modificar al afiliado
        /// </summary>
        /// <param name="afiliado"></param>
        public Respuesta modificarAfiliado(Afiliado afiliado)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_AFILIADO_MODIFICACION", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@USERNAME_ID", afiliado.Id);
                comando.Parameters.AddWithValue("@DIRECCION", afiliado.Direccion);
                comando.Parameters.AddWithValue("@TELEFONO", afiliado.Telefono);
                comando.Parameters.AddWithValue("@E_MAIL", afiliado.Email);
                comando.Parameters.AddWithValue("@ESTADO_CIVIL", afiliado.EstadoCivil);
                comando.Parameters.AddWithValue("@CANT_HIJOS", afiliado.CantHijos);
                comando.Parameters.AddWithValue("@PLAN_MEDICO_ANTERIOR", afiliado.PlanMedicoAnterior);
                comando.Parameters.AddWithValue("@PLAN_MEDICO_NUEVO", afiliado.PlanMedicoActual);
                comando.Parameters.AddWithValue("@DETALLE", afiliado.DatelleModificacion);

                SqlParameter valorRetorno1 = new SqlParameter("@ID_ERROR", SqlDbType.Int);
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
        /// Invoca a FLOPANICMA.SP_AFILIADO_BAJA para dar baja al afiliado
        /// </summary>
        /// <param name="afiliado"></param>

        public Respuesta darBajaAfiliado(Afiliado afiliado)
        {
            Respuesta resultadoSP = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_AFILIADO_BAJA", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@USERNAME_ID", afiliado.Id);
                comando.Parameters.AddWithValue("@ACTIVO_ANTERIOR", afiliado.Activo);
                comando.Parameters.AddWithValue("@ACTIVO_NUEVO", 0);

                SqlParameter valorRetorno1 = new SqlParameter("@ID_ERROR", SqlDbType.Int);
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
