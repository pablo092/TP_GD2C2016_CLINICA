using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class Agenda
    {
        private DateTime fecha;
        private int idProf;
        private int idEsp;
        private int horaInicio;
        private int horaFin;
        private DateTime periodoInicio;
        private DateTime periodoFin;

        public int HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public int HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public int IdProf
        {
            get { return idProf; }
            set { idProf = value; }
        }

        public int IdEsp
        {
            get { return idEsp; }
            set { idEsp = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime PeriodoInicio
        {
            get { return periodoInicio; }
            set { periodoInicio = value; }
        }

        public DateTime PeriodoFin
        {
            get { return periodoFin; }
            set { periodoFin = value; }
        }

        public Agenda()
        {
            
        }

        public Agenda(int idProf, int idEsp, int hI, int hF, DateTime PIni, DateTime PFin, DateTime fecha)
        {
            this.idProf = idProf;
            this.idEsp = idEsp;
            this.horaInicio = hI;
            this.horaFin = hF;
            this.PeriodoFin = PFin;
            this.periodoInicio = PIni;
            this.fecha = fecha;
        }

        public Agenda(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Agenda(DataRowView item)
        {
            this.IdEsp = (int)item.Row[0];
            this.Fecha = (DateTime)item.Row[1];
            this.IdProf = (int)item.Row[0];
        }
    }
}
