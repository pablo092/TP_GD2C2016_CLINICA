using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ClinicaFrba.DAO;

namespace ClinicaFrba.DTO
{
    public class Estado
    {
        public Estado(){}

        public Estado(int idEstado, string descEstado)
        {
            this.Id = idEstado;
            this.Descripcion = descEstado;
        }
        public int Id { get; set; }

        public string Descripcion { get; set; }
    }
}
