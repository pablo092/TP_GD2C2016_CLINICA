using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class TipoEspecialidad
    {
        private String detalle;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public TipoEspecialidad()
        {
            
        }

        public TipoEspecialidad(int id, string detalle)
        {
            this.id = id;
            this.detalle = detalle;
        }

        public TipoEspecialidad(String detalle)
        {
            this.detalle = detalle;
        }

        public TipoEspecialidad(DataRowView item)
        {
            this.Id = (int)item.Row[0];
            this.Detalle = (String)item.Row[1];
        }
    }
}
