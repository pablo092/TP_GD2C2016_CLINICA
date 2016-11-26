using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class RegistrarAtencion
    {
        private Int32 id_pedido;
        private String sintoma;
        private String diagnostico;
        private DateTime fecha;


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Int32 Id_pedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        public String Sintoma
        {
            get { return sintoma; }
            set { sintoma = value; }
        }

        public String Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public RegistrarAtencion()
        {

        }

        public RegistrarAtencion(string sint, string diag,Int32 turno, DateTime fecha_turno)
        {
            this.Id_pedido=turno;
            this.Sintoma = sint;
            this.Diagnostico = diag;
            this.Fecha = fecha_turno;
        }
    }
}
