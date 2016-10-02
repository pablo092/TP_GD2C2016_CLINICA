using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DTO
{
    public class Direccion
    {

        public string Calle { get; set; }

        public decimal? Numero { get; set; }

        public string Departamento { get; set; }

        public decimal? Piso { get; set; }

        public string CodigoPostal { get; set; }

        public string Localidad { get; set; }
    }
}
