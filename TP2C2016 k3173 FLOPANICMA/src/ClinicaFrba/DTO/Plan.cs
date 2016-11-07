using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class Plan
    {
        private String descripcion;
        private int id;
        private int cuota;
        private int costoF;
        private int costoC;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }

        public int CostoF
        {
            get { return costoF; }
            set { costoF = value; }
        }

        public int CostoC
        {
            get { return costoC; }
            set { costoC = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Plan()
        {
            
        }

        public Plan( int id, int cuota, int costoC, int costoF, string descripcion)
        {
            this.id = id;
            this.cuota = cuota;
            this.costoC = costoC;
            this.costoF = costoF;
            this.descripcion = descripcion;
        }

        public Plan(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public Plan(DataRowView item)
        {
            this.Descripcion = (String)item.Row[1];
            this.Id = (int)item.Row[0];
        }
    }
}
