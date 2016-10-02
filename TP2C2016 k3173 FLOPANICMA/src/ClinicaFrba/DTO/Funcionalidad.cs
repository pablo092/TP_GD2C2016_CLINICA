using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ClinicaFrba.DAO;

namespace ClinicaFrba.DTO
{
    public class Funcionalidad
    {
        private String descripcion;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Funcionalidad()
        {
            
        }

        public Funcionalidad( int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Funcionalidad(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public Funcionalidad(DataRowView item)
        {
            this.Descripcion = (String)item.Row[1];
            this.Id = (int)item.Row[0];
        }
    }
}
