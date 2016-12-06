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
    class PedidoTurnoDAO : BaseDao
    {
        public PedidoTurnoDAO()
        {

        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        /// 
        public PedidoTurnoDAO(SqlConnection con)
        {
            conexion = con;
        }

        /// <summary>
        /// Invoca a FLOPANICMA.SP_REGISTRAR_PEDIDO_TURNO para ingresar el pedido de turno
        /// </summary>
        /// <param name="con"></param>
        public void InsertarPedidoTurno(PedidoTurno pedidoTurno)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta(); // devuelve el resultado del stored procedure

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_REGISTRAR_PEDIDO_TURNO", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@FECHA", pedidoTurno.Fecha);
                comando.Parameters.AddWithValue("@MATRICULA", pedidoTurno.MatriculaProfesional);
                comando.Parameters.AddWithValue("@NRO_AFILIADO", pedidoTurno.IdAfiliado);
                comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", pedidoTurno.IdEspecialidad);
                comando.ExecuteNonQuery();  // ejecuta el stored procedure
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

        public Decimal GetIdEspecialidad(string especialidad)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Decimal respuesta = new Decimal();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT ID_ESPECIALIDAD FROM FLOPANICMA.ESPECIALIDAD " +
                                                "WHERE DETALLE = @ESPECIALIDAD", conexion);

                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);

                SqlDataReader reader = comando.ExecuteReader();

                dt.Load(reader);

                respuesta = (Decimal)dt.Rows[0][0];

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
