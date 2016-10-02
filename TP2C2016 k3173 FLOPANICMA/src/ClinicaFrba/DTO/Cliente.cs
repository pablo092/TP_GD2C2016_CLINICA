using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DTO
{
    public class Cliente : Usuario
    {
        public Cliente()
        {
            this.Estado = new Estado();
            this.Direccion = new Direccion();
        }
        private Direccion direccion;
        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int? NumeroDocumento { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string TipoDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        
        public string Login { get; set; }

        public int? IdTipoDocumento { get; set; }

    }
}
