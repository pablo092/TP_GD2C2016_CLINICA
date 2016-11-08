using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    public class Semestre
    {
        public int Id { get; set; }
        public string Periodo { get; set; }

        public Semestre(int vId, string vPeriodo)
        {
            this.Id = vId;
            this.Periodo = vPeriodo;
        }

    }

}
