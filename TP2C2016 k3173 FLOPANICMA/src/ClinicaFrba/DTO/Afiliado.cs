using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class Afiliado : Persona
    {
        private String estadoCivil;
        private int nroAfiliado;
        private long planMedico;
        private Int16 activo;
        private int cantHijos;
        private int nroConsulta;

        public String EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public int NroAfiliado
        {
            get { return nroAfiliado; }
            set { nroAfiliado = value; }
        }

        public long PlanMedico
        {
            get { return planMedico; }
            set { planMedico = value; }
        }

        public Int16 Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public int CantHijos
        {
            get { return cantHijos; }
            set { cantHijos = value; }
        }

        public int NroConsulta
        {
            get { return nroConsulta; }
            set { nroConsulta = value; }
        }

        public Afiliado()
        {
            
        }

        public Afiliado(int nroAfiliado, long pm, Int16 activo, int cH, int nroCons, string estadoCivil)
        {
            this.nroAfiliado = nroAfiliado;
            this.planMedico = pm;
            this.activo = activo;
            this.cantHijos = cH;
            this.nroAfiliado = nroCons;
            this.estadoCivil = estadoCivil;
        }
    }
}
