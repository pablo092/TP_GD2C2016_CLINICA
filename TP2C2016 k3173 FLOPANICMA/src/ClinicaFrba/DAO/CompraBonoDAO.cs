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
    class CompraBonoDAO : BaseDao
    {
        public CompraBonoDAO() 
        {
 
        }

        /// <summary>
        /// Constructor creado para el manejo de transacciones
        /// </summary>
        /// <param name="con"></param>
        /// 
        public CompraBonoDAO(SqlConnection con)
        {
            conexion = con;
        }

        //Invoca a FLOPANICMA.SP_COMPRA_BONOS para insertar una compra de bono
        public void InsertarCompraBono(CompraBono compraBono)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            Respuesta respuesta = new Respuesta(); // devuelve el resultado del stored procedure

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.SP_COMPRA_BONOS", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CANTIDAD", compraBono.CantidadBonos);
                comando.Parameters.AddWithValue("@NRO_AFILIADO", compraBono.NroAfiliado);
                comando.Parameters.AddWithValue("@IMPORTE", compraBono.ImporteTotal);
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
    }
}
