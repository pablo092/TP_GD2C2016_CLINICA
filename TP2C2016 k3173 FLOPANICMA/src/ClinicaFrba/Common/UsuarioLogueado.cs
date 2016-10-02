using ClinicaFrba.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Common
{
    /// <summary>
    /// Utilizar para recuperar valores del usuario logueado.
    /// </summary>
    public static class UsuarioLogueado
    {
        public static Usuario usuario {get; set;}

        public static List<string> funcionalidades { get; set; }
    }
}
