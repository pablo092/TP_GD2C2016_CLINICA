using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Clinica.Common;
using ClinicaFrba.Common;
using ClinicaFrba.DTO;

namespace ClinicaFrba.DAO
{
    class TipoDocumentoDAO :BaseDao
    {
        /// <summary>
        /// Recupera todos los tipos documento de la BD
        /// </summary>
        /// <returns></returns>
        public Respuesta getAll()
        {
            Respuesta respuesta = new Respuesta();

            SqlCommand comando = new SqlCommand("RAT.GET_ALL_TIPOS_DOCUMENTO", conexion);
            try
            {
                comando.CommandType = CommandType.StoredProcedure;

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
    }
}
