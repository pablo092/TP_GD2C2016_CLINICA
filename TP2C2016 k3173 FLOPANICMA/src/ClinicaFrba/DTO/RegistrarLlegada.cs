using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class RegistrarLlegada
    {
        private int id_afiliado;
        private int id_profesional;
        private int id_turno;
        private DateTime hora_llegada;

        public DateTime Hora_llegada
        {
            get { return hora_llegada; }
            set { hora_llegada = value; }
        }

        public int Id_afiliado
        {
            get { return id_afiliado; }
            set { id_afiliado = value; }
        }

        public int Id_profesional
        {
            get { return id_profesional; }
            set { id_profesional = value; }
        }

        public int Id_turno
        {
            get { return id_turno; }
            set { id_turno = value; }
        }

        public RegistrarLlegada(int afiliado, int profesional, int turno, DateTime hora)
        {
            this.Hora_llegada = hora;
            this.Id_afiliado = afiliado;
            this.Id_profesional = profesional;
            this.Id_turno = turno;
        }
    }
}
