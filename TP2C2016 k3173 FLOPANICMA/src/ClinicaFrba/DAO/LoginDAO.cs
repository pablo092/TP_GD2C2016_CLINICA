using ClinicaFrba.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.DAO
{
    class LoginDAO : BaseDao
    {
        
        /// <summary>
        /// Recupera la fecha actual desde la clase Propiedades, y finaliza todas las publicaciones vencidas. 
        /// </summary>
        public void actualizarPublicacionesFinalizadas()
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader reader = null;

            try
            {   
                int idEstadoFinalizada = 0;

                cmd.CommandText = this.queryIdEstadoFinalizada();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    {
                        while (reader.Read())
                        {
                            idEstadoFinalizada = reader.GetInt32(0);
                        }
                    }
                }   
                else
                {
                    MessageBox.Show("Ocurrió un error al procesar las publicaciones vencidas: \n" + "No se pudo recuperar el idEstado");
                    return;
                }
                reader.Close();

                String fechaActual = Propiedades.getFechaActual.ToString("yyyy-MM-dd");

                cmd2.CommandText = this.queryActualizarEstadoPublicaciones(fechaActual, idEstadoFinalizada);
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = conexion;

                cmd2.ExecuteNonQuery();

            } catch(Exception ex){
                MessageBox.Show("Ocurrió un error al procesar las publicaciones vencidas: \n"+ ex);
                return;
            }
            finally
            {
                conexion.Close();
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            

        }

        /// <summary>
        /// Query para recuperar el id estado finalizado de la BD que
        /// recupera todas las publicaciones vencidas (subastas y compra inmediata) y las actualiza a estado finalizada
        /// </summary>
        /// <param name="fechaActual"></param>
        /// <param name="idEstadoPublicacion"></param>
        /// <returns></returns>
        private String queryActualizarEstadoPublicaciones(String fechaActual, int idEstadoPublicacion) {
            return "UPDATE FLOPANICMA.PUBLICACION  " +
                   "SET ID_ESTADO_PUBLICACION = " + idEstadoPublicacion + ",  " +
                   "FECHA_FIN = '" + fechaActual + "' " +
                   "WHERE ID_PUBLICACION IN(  " +
                   "select pu.ID_PUBLICACION  " +
                   "from flopanicma.PUBLICACION pu, flopanicma.ESTADO_PUBLICACION ep  " +
                   "where pu.ID_ESTADO_PUBLICACION = ep.ID_ESTADO_PUBLICACION  " +
                   "and pu.fecha_fin < '" + fechaActual + "'  " +
                   "and ep.DESCRIPCION IN ('PUBLICADA', 'PAUSADA'))";
        }

        /// <summary>
        /// Query para recuperar el id estado finalizado de la BD 
        /// </summary>
        /// <returns></returns>
        private String queryIdEstadoFinalizada() {
            return
                "SELECT ID_ESTADO_PUBLICACION " +
                "FROM FLOPANICMA.ESTADO_PUBLICACION " +
                "WHERE DESCRIPCION = 'FINALIZADA'";
        }
    
    }


}
