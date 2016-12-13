using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ClinicaFrba.DAO;

namespace ClinicaFrba.DTO
{
    public class Rol
    {
        private String descripcion;
        private int id;
        private bool estaHabilitado;
        private Funcionalidad funcionalidad;

        public Funcionalidad Funcionalidad
        {
            get { return funcionalidad; }
            set { funcionalidad = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool EstaHabilitado
        {
            get { return estaHabilitado; }
            set { estaHabilitado = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Rol(DataRow unRol)
        {
            this.id = (int)unRol[0];
            this.descripcion = (string)unRol[1];
            this.estaHabilitado = (bool)unRol[2];
        }

        public Rol(int id, string descripcion, bool habilitado)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.estaHabilitado = habilitado;
        }

        public Rol()
        {

        }
    }
}
