using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.DAO;

namespace ClinicaFrba.DTO
{
    public class Usuario : IUsuario
    {
        private string username;
        private Rol rol;
        private int id;

        public Estado Estado { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        private string clave;
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public Usuario() 
        {
            this.rol = new Rol();
        }
        public Usuario(String username, String clave)
        {
            this.username = username;
            this.clave = clave;
            this.rol = new Rol();
        }
        public Usuario(int id, String username)
        {
            this.id = id;
            this.username = username;
            this.rol = new Rol();
        }
        public Usuario(int id, String username, Rol rol)
        {
            this.id = id;
            this.username = username;
            this.rol = rol;
        }
        public Usuario(String username, String clave, Rol rol)
        {
            this.username = username;
            this.clave = clave;
            this.rol = rol;
        }
    }
}
