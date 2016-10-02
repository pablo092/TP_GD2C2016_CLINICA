using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DTO
{
    public interface IUsuario
    {
        Rol Rol {get;set;}
        string Clave { get; set; }
        string Username { get; set; }
    }
}
