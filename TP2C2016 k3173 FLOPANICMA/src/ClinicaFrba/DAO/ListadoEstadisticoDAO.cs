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
    class ListadoEstadisticoDAO : BaseDao
    {
        public DataTable getEspecialidades()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT DETALLE " +
                                                    "FROM FLOPANICMA.ESPECIALIDAD", conexion);

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

        public DataTable ListadoEspConMasCancelaciones(Int32 anio, Int32 semestre, Int32 mes)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable listado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_LEST_ESP_MAS_CANCELADAS", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@SEMESTRE", semestre);
                comando.Parameters.AddWithValue("@MES", mes);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(listado);
                return listado;
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

        public DataTable ListadoProfMasConsultadosPorPlan(int anio, Int32 semestre, Int32 mes, string filtro)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable listado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_LEST_PROF_MAS_CONSULTADOS_POR_PLAN", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DETALLE_PLAN", filtro);
                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@SEMESTRE", semestre);
                comando.Parameters.AddWithValue("@MES", mes);
                

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(listado);
                return listado;
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

        public DataTable ListadoProfMenosHorasPorEspecialidad(int anio, Int32 semestre, Int32 mes, string filtro)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable listado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_LEST_PROF_MENOS_HS_TRABAJADAS", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ESPECIALIDAD_DETALLE", filtro);
                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@SEMESTRE", semestre);
                comando.Parameters.AddWithValue("@MES", mes);


                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(listado);
                return listado;
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



        public DataTable ListadoMasBonosComprados(Int32 anio, Int32 semestre, Int32 mes)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable listado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_LEST_AFILIADO_MAS_BONOS_COMPRADOS", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@SEMESTRE", semestre);
                comando.Parameters.AddWithValue("@MES", mes);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(listado);
                return listado;
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

        public DataTable ListadoEspConMasBonos(Int32 anio, Int32 semestre, Int32 mes)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            DataTable listado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_LEST_ESPECIALIDAD_MAS_BONOS_USADOS", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@SEMESTRE", semestre);
                comando.Parameters.AddWithValue("@MES", mes);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(listado);
                return listado;
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
