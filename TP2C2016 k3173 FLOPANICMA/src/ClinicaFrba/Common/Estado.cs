using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClinicaFrba.Common
{
    class Estados
    {
        public enum Estado
        {
            Activo = 1,
            Inactivo = 2
        }

        /// <summary>
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int get(bool p)
        {
            if (p)
            {
                return (int)Estados.Estado.Activo;
            }
            else
            {
                return (int)Estados.Estado.Inactivo;
            }
            
        }
    }
}
