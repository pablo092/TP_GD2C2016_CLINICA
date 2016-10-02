﻿using System;
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
    class FuncionalidadDAO  :BaseDao
    {
        /// <summary>
        /// Recupera una lista de todas las funcionalidades. 
        /// invoca a RAT.GET_ALL_FUNCIONALIDADES
        /// </summary>
        /// <returns></returns>
        public DataTable getFuncionalidades()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.GET_ALL_FUNCIONALIDADES", conexion);

                comando.CommandType = CommandType.StoredProcedure;

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

        /// <summary>
        /// Recupera una lista de todas las funcionalidades asignadas a un rol. 
        /// invoca a RAT.GET_FUNCIONALIDADES_POR_ROL
        /// </summary>
        /// <param name="descripcionRol"></param>
        /// <returns></returns>
        public Respuesta getFuncionalidadesByRol(String descripcionRol)
        {
            Respuesta resultadoSP = new Respuesta();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand("RAT.GET_FUNCIONALIDADES_POR_ROL", conexion);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DESCRIPCION_ROL", descripcionRol.ToUpper().Trim());

                SqlParameter valorRetorno1 = new SqlParameter("@FLAG_ERROR", SqlDbType.Int);
                valorRetorno1.Size = sizeof(int);
                valorRetorno1.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno1);

                SqlParameter valorRetorno2 = new SqlParameter("@DESC_ERROR", SqlDbType.VarChar);
                valorRetorno2.Size = 255 * sizeof(char);
                valorRetorno2.Direction = ParameterDirection.Output;
                comando.Parameters.Add(valorRetorno2);

                dt.Load(comando.ExecuteReader());
                resultadoSP.Resultado = dt;

                resultadoSP.CodigoError = (int)valorRetorno1.Value;
                resultadoSP.DescripcionError = valorRetorno2.Value.ToString();

                return resultadoSP;
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
