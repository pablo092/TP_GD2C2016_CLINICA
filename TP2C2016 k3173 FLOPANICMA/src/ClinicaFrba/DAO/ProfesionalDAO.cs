using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class ProfesionalDAO : BaseDao
    {
        public ProfesionalDAO()
        {

        }

        public ProfesionalDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Recupera una lista de todos los profesionales. 
        /// </summary>
        /// <returns></returns>

        public DataTable getProfesionalesXEspecialidad(string esp)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();
   
            try
            {
                SqlCommand comando = new SqlCommand("SELECT PERTAB.NOMBRE, PERTAB.APELLIDO " +
                                                   "FROM FLOPANICMA.PERSONA AS PERTAB JOIN " +
                                                   "FLOPANICMA.PROFESIONAL AS PROTAB ON PERTAB.ID_PERSONA = PROTAB.ID_PROFESIONAL JOIN " +
                                                   "FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESPPROTAB ON PROTAB.ID_PROFESIONAL = ESPPROTAB.ID_PROFESIONAL JOIN " +
                                                   "FLOPANICMA.ESPECIALIDAD AS ESPTAB ON ESPPROTAB.ID_ESPECIALIDAD=ESPTAB.ID_ESPECIALIDAD " +
                                                   "WHERE ESPTAB.DETALLE = @ESPECIALIDAD", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ESPECIALIDAD", esp);

                dt.Load(comando.ExecuteReader());

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


        public DataTable getProfesionales()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_PROFESIONAL, NOMBRE, APELLIDO " +
                                                    "FROM FLOPANICMA.PERSONA " + 
                                                    "JOIN FLOPANICMA.PROFESIONAL ON " + 
                                                    "ID_PERSONA = ID_PROFESIONAL", conexion);

                comando.CommandType = CommandType.Text;

                dt.Load(comando.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        public DataTable GetFechasDisponiblesPorProfesional(int matricula)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable respuesta = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.GET_FECHAS_DISPONIBLES_AGENDA_PROFESIONAL", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@MATRICULA", matricula);

                SqlDataReader reader = comando.ExecuteReader();
                respuesta.Load(reader);
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

        public DataTable GetProfesionalesPorEspecialidad(string especialidad)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable respuesta = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand(" SELECT PROF.ID_PROFESIONAL, PER.NOMBRE, PER.APELLIDO, PROF.MATRICULA " +
                                               " FROM   FLOPANICMA.PERSONA AS PER " +
                                               " INNER JOIN FLOPANICMA.PROFESIONAL AS PROF " +
                                               "         ON ( PER.ID_PERSONA = PROF.ID_PROFESIONAL ) " +
                                               " INNER JOIN FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESPPROF " +
                                               "         ON ( PROF.ID_PROFESIONAL = ESPPROF.ID_PROFESIONAL ) " +
                                               " INNER JOIN FLOPANICMA.ESPECIALIDAD AS ESP " +
                                               "         ON ( ESPPROF.ID_ESPECIALIDAD = ESP.ID_ESPECIALIDAD ) " +
                                               " WHERE ESP.DETALLE = @ESPECIALIDAD", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);

                SqlDataReader reader = comando.ExecuteReader();
                respuesta.Load(reader);

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


        }
}
