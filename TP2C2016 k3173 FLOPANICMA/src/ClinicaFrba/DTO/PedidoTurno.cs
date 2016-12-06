using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class PedidoTurno
    {
        // atributos
        private Decimal idTurno;
        private DateTime fecha;
        private int matriculaProfesional; // en la aplicacion usamos la matricula que es unica, ya que no es correcto mostrar el Id al usuario
        private int idAfiliado;
        private Decimal idEspecialidad;

        //propiedades 
        public Decimal IdTurno
        { 
            get { return idTurno; }
            set { idTurno = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int MatriculaProfesional
        {
            get { return matriculaProfesional; }
            set { matriculaProfesional = value; }
        }

        public int IdAfiliado 
        {
            get { return idAfiliado; }
            set { idAfiliado = value; }
        }

        public Decimal IdEspecialidad
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }
        }

        // constructor nulo
        public PedidoTurno(){} 

        //constructor con parametros
        public PedidoTurno(Decimal idTurno, DateTime fecha, int matrProf, int idAfi, Decimal idEsp)
        {
            this.idTurno = idTurno;
            this.fecha = fecha;
            this.matriculaProfesional = matrProf;
            this.idAfiliado = idAfi;
            this.idEspecialidad = idEsp;
        }
    }
}
