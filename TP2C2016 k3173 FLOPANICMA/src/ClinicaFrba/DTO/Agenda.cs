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
        private String dia;
        private Int32 idProf;
        private Decimal idEsp;
        private Int32 horaInicio;
        private Int32 horaFin;
        private DateTime periodoInicio;
        private DateTime periodoFin;

        public Int32 HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public Int32 HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public Int32 IdProf
        {
            get { return idProf; }
            set { idProf = value; }
        }

        public Decimal IdEsp
        {
            get { return idEsp; }
            set { idEsp = value; }
        }

        public String Dia
        {
            get { return dia; }
            set { dia = value; }
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

        public Agenda(int idProf, Decimal idEsp, int hI, int hF, DateTime PIni, DateTime PFin, String day)
        {
            this.idProf = idProf;
            this.idEsp = idEsp;
            this.horaInicio = hI;
            this.horaFin = hF;
            this.PeriodoFin = PFin;
            this.periodoInicio = PIni;
            this.dia = day;
        }

      /*  public Agenda(String day)
        {
            this.dia = day;
        }

        public Agenda(DataRowView item)
        {
            this.IdEsp = (Int32)item.Row[0];
            this.Dia = (String)item.Row[1];
            this.IdProf = (int)item.Row[0];
        }*/
    }
}
