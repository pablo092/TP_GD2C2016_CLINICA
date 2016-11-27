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

        public DataTable getPacientesXProfesional(int prof_id)
        { DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT DISTINCT PER.NOMBRE,PER.APELLIDO FROM FLOPANICMA.PERSONA PER JOIN FLOPANICMA.AFILIADO AFI "+
                                                    "ON PER.ID_PERSONA=AFI.ID_AFILIADO JOIN FLOPANICMA.PEDIDO_TURNO TUR ON TUR.ID_AFILIADO=AFI.ID_AFILIADO " +
                                                    "WHERE ID_PROFESIONAL = @PROFESIONAL AND FECHA = GETDATE()", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@PROFESIONAL", prof_id);

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
