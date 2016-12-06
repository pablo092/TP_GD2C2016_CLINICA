using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DTO
{
    public class Persona
    {
        public int? Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Sexo { get; set; }

        public string TipoDocumento { get; set; }

        public int? NumeroDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        
        public string Login { get; set; }

        public string Estado_Civil { get; set; }

        public int Cantidad_Hijos { get; set; }

    }
}
