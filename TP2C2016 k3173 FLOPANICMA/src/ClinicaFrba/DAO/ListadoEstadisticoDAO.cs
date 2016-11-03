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
        /// <summary>
        /// Retorna un listado de los 5 vendedores con mayor cantidad de productos no vendidos.
        /// invoca a FLOPANICMA.LISTADO_TOP_VENDEDORES_PRODUCTOS_NO_VENDIDOS
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="trimestre"></param>
        /// <param name="idVisibilidad"></param>
        /// <returns></returns>
        public Respuesta getTop5ProductosNoVendidos(int anio, Trimestre trimestre, int idVisibilidad)
        {
            Respuesta respuesta = new Respuesta();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.LISTADO_TOP_VENDEDORES_PRODUCTOS_NO_VENDIDOS", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@TRIMESTRE", trimestre.Id);
                comando.Parameters.AddWithValue("@ID_VISIBILIDAD", idVisibilidad);

                SqlParameter vFlagError = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                vFlagError.Size = sizeof(int);
                vFlagError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vFlagError);

                SqlParameter vDescripcionError = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                vDescripcionError.Size = 255 * sizeof(char);
                vDescripcionError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vDescripcionError);

                dt.Load(comando.ExecuteReader());
                respuesta.Resultado = dt;

                respuesta.CodigoError = (int)vFlagError.Value;
                respuesta.DescripcionError = vDescripcionError.Value.ToString();

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

        
        /// <summary>
        /// Retorna un listado de los 5 productos más comprados.
        /// invoca a FLOPANICMA.LISTADO_TOP_PRODUCTOS_COMPRADOS
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="trimestre"></param>
        /// <param name="idRubro"></param>
        /// <returns></returns>
        public Respuesta getTop5ProductosComprados(int anio, Trimestre trimestre, int idRubro)
        {
            Respuesta respuesta = new Respuesta();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.LISTADO_TOP_PRODUCTOS_COMPRADOS", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@TRIMESTRE", trimestre.Id);
                comando.Parameters.AddWithValue("@ID_RUBRO", idRubro);

                SqlParameter vFlagError = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                vFlagError.Size = sizeof(int);
                vFlagError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vFlagError);

                SqlParameter vDescripcionError = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                vDescripcionError.Size = 255 * sizeof(char);
                vDescripcionError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vDescripcionError);

                dt.Load(comando.ExecuteReader());
                respuesta.Resultado = dt;

                respuesta.CodigoError = (int)vFlagError.Value;
                respuesta.DescripcionError = vDescripcionError.Value.ToString();

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

        /// <summary>
        /// Retorna un listado de las 5 vendedores con mayor cantidad de facturas. 
        /// invoca a FLOPANICMA.LISTADO_TOP_FACTURAS_POR_VENDEDOR
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="trimestre"></param>
        /// <returns></returns>
        public Respuesta getTop5FacturasPorVendedor(int anio, Trimestre trimestre)
        {
            Respuesta respuesta = new Respuesta();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.LISTADO_TOP_FACTURAS_POR_VENDEDOR", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@TRIMESTRE", trimestre.Id);
                
                SqlParameter vFlagError = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                vFlagError.Size = sizeof(int);
                vFlagError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vFlagError);

                SqlParameter vDescripcionError = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                vDescripcionError.Size = 255 * sizeof(char);
                vDescripcionError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vDescripcionError);

                dt.Load(comando.ExecuteReader());
                respuesta.Resultado = dt;

                respuesta.CodigoError = (int)vFlagError.Value;
                respuesta.DescripcionError = vDescripcionError.Value.ToString();

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

        /// <summary>
        /// Retorna un listado de las 5 facturas con mayor monto. 
        /// invoca a FLOPANICMA.LISTADO_TOP_MONTO_FACTURAS_POR_VENDEDOR
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="trimestre"></param>
        /// <returns></returns>
        public Respuesta getTop5MontoFacturasPorVendedor(int anio, Trimestre trimestre)
        {
            Respuesta respuesta = new Respuesta();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("FLOPANICMA.LISTADO_TOP_MONTO_FACTURAS_POR_VENDEDOR", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@ANIO", anio);
                comando.Parameters.AddWithValue("@TRIMESTRE", trimestre.Id);

                SqlParameter vFlagError = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                vFlagError.Size = sizeof(int);
                vFlagError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vFlagError);

                SqlParameter vDescripcionError = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                vDescripcionError.Size = 255 * sizeof(char);
                vDescripcionError.Direction = ParameterDirection.Output;
                comando.Parameters.Add(vDescripcionError);

                dt.Load(comando.ExecuteReader());
                respuesta.Resultado = dt;

                respuesta.CodigoError = (int)vFlagError.Value;
                respuesta.DescripcionError = vDescripcionError.Value.ToString();

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

        /// <summary>
        /// Retorna una Lista con los 4 métodos de filtro para ejecutar
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<Metodo, String>> getMetodosFiltro()
        {

            List<KeyValuePair<Metodo, String>> lista = new List<KeyValuePair<Metodo, String>>();

            lista.Add(new KeyValuePair<Metodo, String>(Metodo.ProductosNoVendidosPorVisibilidad, "Vendedores con mayor cantidad de productos no vendidos"));
            lista.Add(new KeyValuePair<Metodo, String>(Metodo.ProductosCompradosPorRubro, "Clientes con mayor cantidad de productos comprados"));
            lista.Add(new KeyValuePair<Metodo, String>(Metodo.FacturasPorVendedor, "Vendedores con mayor cantidad de facturas"));
            lista.Add(new KeyValuePair<Metodo, String>(Metodo.MontoPorVendedor, "Vendedores con mayor monto facturado"));

            return lista;
        }

        /// <summary>
        /// Retorna un enum con los métodos de filtro para ejecutar
        /// </summary>
        public enum Metodo : int{
            ProductosNoVendidosPorVisibilidad = 1,
            ProductosCompradosPorRubro = 2,
            FacturasPorVendedor = 3,
            MontoPorVendedor = 4
        }
    }
}
