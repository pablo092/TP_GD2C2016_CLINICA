using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DTO
{
    class CompraBono
    {
        // atributos
        private int idOperacion;
        private int nroAfiliado;
        private int cantidadBonos;
        private DateTime fechaCompra;
        private DateTime fechaImpresion;
        private Decimal importeTotal;

        // propiedades
        public int IdOperacion
        {
            get { return idOperacion; }
            set { idOperacion = value; }
        }

        public int NroAfiliado 
        {
            get { return nroAfiliado; }
            set { nroAfiliado = value; }
        }

        public int CantidadBonos 
        {
            get { return cantidadBonos; }
            set { cantidadBonos = value; }
        }

        public DateTime FechaCompra 
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }

        public DateTime FechaImpresion 
        {
            get { return fechaImpresion; }
            set { fechaImpresion = value; }
        }

        public Decimal ImporteTotal 
        {
            get { return importeTotal; }
            set { importeTotal = value; }
        }

        // constructor nulo
        public CompraBono() { } 

        //constructor con parametros
        public CompraBono(int idOper, int nroAfil, int cantBonos, DateTime fechaCompr, DateTime fechaImpr, Decimal importe)
        {
            this.idOperacion = idOper;
            this.nroAfiliado = nroAfil;
            this.cantidadBonos = cantBonos;
            this.fechaCompra = fechaCompr;
            this.fechaImpresion = fechaImpr;
            this.importeTotal = importe;
        }
    }
}
