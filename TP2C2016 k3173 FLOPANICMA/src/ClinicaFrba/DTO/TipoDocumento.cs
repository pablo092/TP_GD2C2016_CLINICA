using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ClinicaFrba.DAO;

namespace ClinicaFrba.DTO
{
    public class TipoDocumento
    {
        private String descripcion;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
    }
}
