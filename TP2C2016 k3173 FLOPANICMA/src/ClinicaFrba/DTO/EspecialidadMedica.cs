using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class EspecialidadMedica
    {
        private String detalle;
        private Decimal idTipoEspecialidad;
        private Decimal id;

        public Decimal Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public Decimal IdTipoEspecialidad
        {
            get { return idTipoEspecialidad; }
            set { idTipoEspecialidad = value; }
        }

        public EspecialidadMedica()
        {
            
        }

        public EspecialidadMedica(Decimal id, Decimal idTipoEspecialidad, String detalle)
        {
            this.id = id;
            this.idTipoEspecialidad = idTipoEspecialidad;
            this.detalle = detalle;
        }

        public EspecialidadMedica(String detalle)
        {
            this.detalle = detalle;
        }

        public EspecialidadMedica(DataRowView item)
        {
            this.Detalle = (String)item.Row[2];
            this.IdTipoEspecialidad = (int)item.Row[1];
            this.Id = (int)item.Row[0];
        }
    }
}
