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
        private int idTipoEspecialidad;
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

        public int IdTipoEspecialidad
        {
            get { return idTipoEspecialidad; }
            set { idTipoEspecialidad = value; }
        }

        public EspecialidadMedica()
        {
            
        }

        public EspecialidadMedica(int id, int idTipoEspecialidad, string detalle)
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
