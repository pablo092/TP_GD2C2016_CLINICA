using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace ClinicaFrba.Common
{
    /// <summary>
    /// Debe utilizarse para setear las respuestas de las DAOs. 
    /// </summary>
    class Respuesta
    {
        public Respuesta()
        {
            Resultado = new DataTable();
        }

        private int codigoError = 0; //esto es para evitar un posible null pointer. La respuesta siempre esta OK por default.

        public int CodigoError
        {
            get { return codigoError; }
            set { codigoError = value; }
        }

        private string descripcionError;

        public string DescripcionError
        {
            get { return descripcionError; }
            set { descripcionError = value; }
        }

        private Object parametroAdicional;

        public Object ParametroAdicional
        {
            get { return parametroAdicional; }
            set { parametroAdicional = value; }
        }

        private DataTable resultado;

        public DataTable Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

    }
}
