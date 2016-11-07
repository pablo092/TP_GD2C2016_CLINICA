using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class Profesional : Persona
    {
        private int matricula;
        private int horasAcumuladas;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int HorasAcumuladas
        {
            get { return horasAcumuladas; }
            set { horasAcumuladas = value; }
        }
        public Profesional()
        {
            
        }

        public Profesional(int id, int matricula, int horasAcumuladas)
        {
            this.Id = id;
            this.matricula = matricula;
            this.horasAcumuladas = horasAcumuladas;
        }

        public Profesional(int id)
        {
            this.Id = id;
        }

        public Profesional(DataRowView item)
        {
            this.HorasAcumuladas = (int)item.Row[2];
            this.Matricula = (int)item.Row[1];
            this.Id = (int)item.Row[0];
        }
    }
}
