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
    class CancelarAtencionDAO : BaseDao
    {
        internal string GetPersonaXUsuario(int p)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT APELLIDO,NOMBRE FROM FLOPANICMA.PERSONA AS PER JOIN " +
                                                "FLOPANICMA.USUARIO AS U ON U.ID_PERSONA = PER.ID_PERSONA " +
                                                "WHERE ID_USUARIO=@USUARIO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@USUARIO", p);

                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                String respuesta;

                respuesta = "Bienvenido " + (String)dt.Rows[0][0] + " " + (String)dt.Rows[0][1];

                return respuesta;
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

        internal int GetIdPorUsuario(int p)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.USUARIO " +
                                                "WHERE ID_USUARIO=@USUARIO", conexion);

                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@USUARIO", p);

                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                Int32 respuesta = (Int32) dt.Rows[0][0];

                return respuesta;
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

        internal int GetIdPorNroAfiliado(string p)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Int32 nro_afiliado =Convert.ToInt32(p.Substring(0,p.IndexOf("-")));

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_AFILIADO FROM FLOPANICMA.AFILIADO " +
                                                "WHERE NRO_AFILIADO = @NRO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@NRO", nro_afiliado);
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

        internal decimal GetTurno(int afiliado, string fecha)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DateTime fecha_turno = Convert.ToDateTime(fecha); 
            
            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_TURNO FROM FLOPANICMA.PEDIDO_TURNO " +
                                                "WHERE FECHA = @FECHA AND ID_AFILIADO = @AFILIADO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@AFILIADO", afiliado);
                comando.Parameters.AddWithValue("@FECHA", fecha_turno);
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

        internal void RegistrarCancelacionAfiliado(decimal turno, string detalle)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_CANCELACION_TURNO_AFILIADO", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID_TURNO", turno);
                comando.Parameters.AddWithValue("@DETALLE", detalle);
                
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

        internal int RegistrarCancelacionProfesional(DateTime Inicio, DateTime fin, Int32 id_profesional, String detalle)
        {
            if(conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_CANCELACION_TURNO_PROFESIONAL", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@INICIO", Inicio);
                comando.Parameters.AddWithValue("@FIN", fin);
                comando.Parameters.AddWithValue("ID_PROFESIONAL", id_profesional);
                comando.Parameters.AddWithValue("@DETALLE", detalle);
                return comando.ExecuteNonQuery();
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



        public DataTable GetFechasTurnos(int nro_afiliado)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
               SqlCommand comando = new SqlCommand("SELECT PED.FECHA FROM FLOPANICMA.PEDIDO_TURNO AS PED " +
                                                    "WHERE PED.ID_AFILIADO = (SELECT AFI.ID_AFILIADO " +
                                                    "FROM FLOPANICMA.AFILIADO AS AFI WHERE AFI.NRO_AFILIADO = @NRO_AFILIADO) " +
                                                    "AND PED.FECHA > DATEADD(DAY,2,@FECHA) " +
                                                    "AND PED.ID_TURNO NOT IN (SELECT ID_TURNO_CANCELADO FROM FLOPANICMA.CANCELACION)", conexion);
                
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@NRO_AFILIADO", nro_afiliado);
                comando.Parameters.AddWithValue("@FECHA", DateTime.Today);

                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

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
    }
}
