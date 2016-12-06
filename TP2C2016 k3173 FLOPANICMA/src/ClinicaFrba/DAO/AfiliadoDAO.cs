using ClinicaFrba.Common;
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

        public Respuesta GetAfiliado(int numeroAfiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT NRO_AFILIADO " +
                                                    "FROM FLOPANICMA.AFILIADO " +
                                                    "WHERE NRO_AFILIADO = " + numeroAfiliado, conexion);
                comando.CommandType = CommandType.Text;

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

        public bool AfiliadoExistente(int numeroAfiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT CASE WHEN EXISTS " +
                                                     "(SELECT * FROM FLOPANICMA.AFILIADO " +
                                                     "WHERE NRO_AFILIADO = @NRO_AFILIADO) " +
                                                     "THEN CAST (1 AS BIT) " +
                                                     "ELSE CAST(0 AS BIT) END", conexion);
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@NRO_AFILIADO", numeroAfiliado);

                dt.Load(comando.ExecuteReader());

                return (bool)dt.Rows[0][0]; // casteo y devuelvo el valor booleano
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
        }


        public Decimal GetCostoBonoConsulta(int nroAfiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT COSTO_CONSULTA " +
                                                    "FROM FLOPANICMA.AFILIADO " +
                                                    "INNER JOIN FLOPANICMA.PLAN_MEDICO " +
                                                    "ON (PLAN_MEDICO = ID_PLAN) " +
                                                    "WHERE NRO_AFILIADO = @NRO_AFILIADO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@NRO_AFILIADO", nroAfiliado);

                return Convert.ToDecimal(comando.ExecuteScalar());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
        }

        public int GetNroAfiliadoPorUsuario(int idUsuario)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT NRO_AFILIADO " +
                                                "FROM FLOPANICMA.AFILIADO AS AFI " +
                                                "INNER JOIN FLOPANICMA.PERSONA AS PER " +
                                                "ON ( AFI.ID_AFILIADO = PER.ID_PERSONA ) " +
                                                "INNER JOIN FLOPANICMA.USUARIO AS USU " +
                                                "ON ( PER.ID_PERSONA = USU.ID_PERSONA ) " +
                                                "WHERE USU.ID_USUARIO = @ID_USUARIO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ID_USUARIO", idUsuario);

                return Convert.ToInt32(comando.ExecuteScalar());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
        }



        internal DataTable FamiliaresPorAfiliado(int usuario)
        {
            if(conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                AfiliadoDAO afi = new AfiliadoDAO();

                Int32 afiliado = new Int32();

                afiliado = afi.GetNroAfiliadoPorUsuario(usuario);

                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_FAMILIARES", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NRO_AFILIADO", afiliado);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);

                return dt;
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            
            finally
            {
                conexion.Close();
            }
        }

        internal int GetIdPorNroAfiliado(decimal nro_afiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_AFILIADO FROM FLOPANICMA.AFILIADO " +
                                                    "WHERE NRO_AFILIADO = @NRO_AFILIADO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@NRO_AFILIADO", nro_afiliado);

                return Convert.ToInt32 (comando.ExecuteScalar());
            }

            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            }

        internal DTO.Afiliado DatosAfiliadoPorNroAfiliado(int nroAfiliado)
        {
           if (conexion.State==ConnectionState.Closed)
           {
               conexion.Open();
           }
            
            DataTable dt = new DataTable();
            DTO.Afiliado persona = new DTO.Afiliado();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_GET_AFILIADO_PARA_MODIF", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NRO_AFILIADO",nroAfiliado);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    persona.NroAfiliado = Convert.ToInt32(dt.Rows[0][0]);
                    persona.Nombre = Convert.ToString(dt.Rows[0][1]);
                    persona.Apellido = Convert.ToString(dt.Rows[0][2]);
                    persona.Direccion = Convert.ToString(dt.Rows[0][3]);
                    persona.Telefono = Convert.ToString(dt.Rows[0][4]);
                    persona.Email = Convert.ToString(dt.Rows[0][5]);
                    persona.Estado_Civil = Convert.ToString(dt.Rows[0][6]);
                    persona.Cantidad_Hijos = Convert.ToInt32(dt.Rows[0][7]);
                    persona.PlanMedico = Convert.ToString(dt.Rows[0][8]);
                }
                else
                {
                    persona.Nombre = "No se registra afiliado con ese numero";
                }

                return persona;

            }
            
            catch(Exception ex)
            {
                throw ex;
            }
            
            finally
            {
                conexion.Close();
            }
        }

        public bool AfiliadoRegistrado(decimal nro)
        {

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT COUNT(NRO_DOCUMENTO) FROM FLOPANICMA.PERSONA " +
                                                    "WHERE NRO_DOCUMENTO = @NRO_DOCUMENTO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@NRO_DOCUMENTO", nro);

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                if (cantidad != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        internal int RegistrarAfiliado(DTO.Afiliado afiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_ALTA_AFILIADO_RAIZ", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NOMBRE",afiliado.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO",afiliado.Apellido);
                comando.Parameters.AddWithValue("@DIRECCION",afiliado.Direccion);
                comando.Parameters.AddWithValue("@TELEFONO",afiliado.Telefono);
                comando.Parameters.AddWithValue("@E_MAIL",afiliado.Email);
                comando.Parameters.AddWithValue("@F_NACIMIENTO",afiliado.FechaNacimiento);
                comando.Parameters.AddWithValue("@TIPO_DOCUMENTO",afiliado.TipoDocumento);
                comando.Parameters.AddWithValue("@NRO_DOCUMENTO",afiliado.NumeroDocumento);
                comando.Parameters.AddWithValue("@SEXO",afiliado.Sexo);
                comando.Parameters.AddWithValue("@PLAN_MEDICO",Convert.ToDecimal(afiliado.PlanMedico));
                comando.Parameters.AddWithValue("@ESTADO_CIVIL",afiliado.Estado_Civil);
                comando.Parameters.AddWithValue("@CANTIDAD_FAMILIARES", afiliado.Cantidad_Hijos);

                SqlParameter nro_afiliado = new SqlParameter("@NRO_AFILIADO", SqlDbType.Int);
                nro_afiliado.Size = sizeof(Int32);
                nro_afiliado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(nro_afiliado);

                comando.ExecuteNonQuery();

                return Convert.ToInt32(nro_afiliado.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        internal void ActualizarAfiliado(DTO.Afiliado afiliado, string detalle)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_MODIFICAR_AFILIADO", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@DIRECCION",afiliado.Direccion);
                comando.Parameters.AddWithValue("@TELEFONO",Convert.ToDecimal(afiliado.Telefono));
                comando.Parameters.AddWithValue("@E_MAIL",afiliado.Email);
                comando.Parameters.AddWithValue("@DESC_PLAN_MEDICO",afiliado.PlanMedico);
                comando.Parameters.AddWithValue("@ESTADO_CIVIL",afiliado.Estado_Civil);
                comando.Parameters.AddWithValue("@CANTIDAD_HIJOS",afiliado.Cantidad_Hijos);
                comando.Parameters.AddWithValue("@NRO_AFILIADO",afiliado.NroAfiliado);
                comando.Parameters.AddWithValue("@FECHA",DateTime.Now);
                comando.Parameters.AddWithValue("@DETALLE",detalle);

                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        internal int RegistarFamiliar(DTO.Afiliado afiliado, int nro_raiz)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                int nro_sig_afiliado = new AfiliadoDAO().UltimoAfiliado(nro_raiz);

                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_ALTA_AFILIADO_ASOCIADO", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NOMBRE",afiliado.Nombre);
                comando.Parameters.AddWithValue("@APELLIDO",afiliado.Apellido);
                comando.Parameters.AddWithValue("@DIRECCION",afiliado.Direccion);
                comando.Parameters.AddWithValue("@TELEFONO",afiliado.Telefono);
                comando.Parameters.AddWithValue("@E_MAIL",afiliado.Email);
                comando.Parameters.AddWithValue("@F_NACIMIENTO",afiliado.FechaNacimiento);
                comando.Parameters.AddWithValue("@TIPO_DOCUMENTO",afiliado.TipoDocumento);
                comando.Parameters.AddWithValue("@NRO_DOCUMENTO",afiliado.NumeroDocumento);
                comando.Parameters.AddWithValue("@SEXO",afiliado.Sexo);
                comando.Parameters.AddWithValue("@PLAN_MEDICO",afiliado.PlanMedico);
                comando.Parameters.AddWithValue("@ESTADO_CIVIL",afiliado.Estado_Civil);
                comando.Parameters.AddWithValue("@CANTIDAD_FAMILIARES",afiliado.Cantidad_Hijos);
                comando.Parameters.AddWithValue("@NRO_AFILIADO",nro_sig_afiliado);
                conexion.Open();

                comando.ExecuteNonQuery();

                return nro_sig_afiliado;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
        }

        public int UltimoAfiliado(int nro_raiz)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            DataTable familiares = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_FAMILIARES", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NRO_AFILIADO",nro_raiz);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(familiares);

                if (familiares.Rows.Count == 0)
                {
                    return (nro_raiz + 1);
                }
                else
                {
                    return (Convert.ToInt32(familiares.Rows[0][0])+1);
                }
            }
            
            catch(Exception ex)
            {
                throw ex;
            }
            
            finally
            {
                conexion.Close();
            }
        }

        internal int GetNroAfiliadoPorDocumento(decimal nro)
        {
            if (conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT NRO_AFILIADO FROM FLOPANICMA.AFILIADO AS AFI JOIN " +
                                                    "FLOPANICMA.PERSONA AS PER ON PER.ID_PERSONA = AFI.ID_AFILIADO " +
                                                    "WHERE NRO_DOCUMENTO = @NRO_DOCUMENTO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@NRO_DOCUMENTO", nro);

                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                if (dt.Rows.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

               
        }

        internal int GetIdPorDocumento(decimal nro)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.PERSONA " +
                                                    "WHERE NRO_DOCUMENTO = @NRO_DOCUMENTO", conexion);

                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@NRO_DOCUMENTO", nro);
                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                if (dt.Rows.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        internal void AgruparFamiliares(int nroAfiliadoNuevo, int idVinculado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_VINCULAR_AFILIADOS", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NUEVO_NUMERO_AFILIADO",nroAfiliadoNuevo);
                comando.Parameters.AddWithValue("@ID_AFILIADO_A_VINCULAR",idVinculado);

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
        }

        internal bool EstaVinculado(string afi1, string afi2)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            try
            {
                SqlCommand comando = new SqlCommand("SELECT FLOPANICMA.SON_FAMILIARES(@AFI1,@AFI2)", conexion);

                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@AFI1",afi1);
                comando.Parameters.AddWithValue("@AFI2",afi2);

                int valor = Convert.ToInt32(comando.ExecuteScalar());

                if (valor == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        internal bool TurnoReservado(DateTime fecha,int nroAfiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT FLOPANICMA.TURNO_OCUPADO(@FECHA,@NRO_AFILIADO)", conexion);

                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@FECHA", fecha);
                comando.Parameters.AddWithValue("@NRO_AFILIADO", nroAfiliado);

                int valor = Convert.ToInt32(comando.ExecuteScalar());

                if (valor == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

