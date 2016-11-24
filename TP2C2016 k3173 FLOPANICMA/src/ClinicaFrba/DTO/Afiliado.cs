using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    public class Afiliado : Persona
    {
        private String estadoCivil;
        private string nroAfiliado;
        private string planMedicoAnterior;
        private string planMedicoActual;
        private string datelleModificacion;
        private Int16 activo;
        private int cantHijos;
        private int nroConsulta;

        public String EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public string NroAfiliado
        {
            get { return nroAfiliado; }
            set { nroAfiliado = value; }
        }

        public string PlanMedicoAnterior
        {
            get { return planMedicoAnterior; }
            set { planMedicoAnterior = value; }
        }

        public string PlanMedicoActual
        {
            get { return planMedicoActual; }
            set { planMedicoActual = value; }
        }

        public string DatelleModificacion
        {
            get { return datelleModificacion; }
            set { datelleModificacion = value; }
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

        public Afiliado(string nroAfiliado, string pmAnt, string pmAct, Int16 activo, int cH, int nroCons, string estadoCivil, string dm)
        {
            this.nroAfiliado = nroAfiliado;
            this.planMedicoAnterior = pmAnt;
            this.planMedicoAnterior = pmAct;
            this.datelleModificacion = dm;
            this.activo = activo;
            this.cantHijos = cH;
            this.nroConsulta = nroCons;
            this.estadoCivil = estadoCivil;
        }
    }
}
