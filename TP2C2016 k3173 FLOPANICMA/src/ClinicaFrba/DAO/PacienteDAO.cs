using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaFrba.DAO
{
    class PacienteDAO : BaseDao
    {
    
        public DataTable getPacientesXProfesional(int usuario)
        {
            int prof_id = getIdProfesional(usuario);

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            
            DataTable dt = new DataTable();

            try
            {
                DateTime inicio = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,7,0,0);
                DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);

                SqlCommand comando = new SqlCommand("SELECT A.NRO_AFILIADO, P.NOMBRE, P.APELLIDO FROM FLOPANICMA.PERSONA AS P JOIN "+
                                                             "FLOPANICMA.AFILIADO AS A ON P.ID_PERSONA = A.ID_AFILIADO JOIN "+
                                                             "FLOPANICMA.PEDIDO_TURNO AS T ON A.ID_AFILIADO = T.ID_AFILIADO JOIN "+
                                                             "FLOPANICMA.CONSULTA AS C ON T.ID_TURNO = C.ID_TURNO "+
                                                             "WHERE T.ID_PROFESIONAL = @ID_PROFESIONAL AND C.REGISTRO_ATENCION IS NULL "+
                                                             "AND C.REGISTRO_LLEGADA IS NOT NULL AND T.FECHA BETWEEN @INICIO AND @FIN", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ID_PROFESIONAL", prof_id);
                comando.Parameters.AddWithValue("@INICIO",inicio);
                comando.Parameters.AddWithValue("@FIN",fin);

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

        public int getIdProfesional(int usuario)
        {
            if(conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PERSONA FROM FLOPANICMA.USUARIO " +
                                                    "WHERE ID_USUARIO = @ID_USUARIO", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ID_USUARIO", usuario);

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

        

        public PacienteDAO()
        {

        }

        public PacienteDAO(SqlConnection con)
        {
            conexion=con;
        }

        ///Devuelve los pacientes de un profesional en la fecha actual

        public DataTable getPacientes()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT NOMBRE, APELLIDO FROM FLOPANICMA.PERSONA AS PERTAB " +
                                                    "JOIN FLOPANICMA.AFILIADO AS AFITAB ON PERTAB.ID_PERSONA=AFITAB.ID_AFILIADO", conexion);

                comando.CommandType = CommandType.Text;

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

        public DataTable getProfesional(int id_usuario)
        {
            DataTable prof = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT PERTAB.ID_PERSONA FROM FLOPANICMA.PERSONA AS PERTAB JOIN " +
                                                    "FLOPANICMA.USUARIO AS USUTAB ON PERTAB.ID_PERSONA = USUTAB.ID_PERSONA" +
                                                    "WHERE ID_USUARIO = @ID_USUARIO", conexion);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ID_USUARIO", id_usuario);

                SqlDataReader reader = comando.ExecuteReader();

                prof.Load(reader);

                return prof;
                
                
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
