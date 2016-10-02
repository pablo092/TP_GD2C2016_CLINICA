using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Common
{
    class Validador
    {
        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///     Solo numeros, sin puntos
        ///     Maximo 8 caraceres
        /// </summary>
        /// <param name="e"></param>
        /// <param name="numDni"></param>
        public static void validarDni(KeyPressEventArgs e, TextBox numDni)
        {
            if (e.KeyChar == '.') {
                e.Handled = true;
                return;
            }
            
            if (!(char.IsNumber(e.KeyChar)) 
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                )
            {
                e.Handled = true;
                return;
            }

            int nroDec = 1;

            for (int i = 0; i < numDni.Text.Length; i++)
            {
                if (nroDec++ >= 8)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///     Numeros, parentesis, barras, guiones y espacios
        ///     Maximo 30 caracteres
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txtTelefonoCliente"></param>
        public static void validarTelefono(KeyPressEventArgs e, TextBox txtTelefonoCliente)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            
            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                && (e.KeyChar != (char)Keys.Space)
                && (e.KeyChar != '-')
                && (e.KeyChar != '(')
                && (e.KeyChar != ')')
                && (e.KeyChar != '/')
                )
            {
                e.Handled = true;
                return;
            }

            int nroDec = 1;

            for (int i = 0; i < txtTelefonoCliente.Text.Length; i++)
            {
                if (nroDec++ >= 30)
                {
                    e.Handled = true;
                    return;
                }
            }

        }

        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///     Numeros y guiones, sin puntos
        ///     Maximo 15 caracteres
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txtCuit"></param>
        internal static void validarCuit(KeyPressEventArgs e, TextBox txtCuit)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            
            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                && (e.KeyChar != (char)Keys.Space)
                && (e.KeyChar != '-')
                )
            {
                e.Handled = true;
                return;
            }

            int nroDec = 1;

            for (int i = 0; i < txtCuit.Text.Length; i++)
            {
                if (nroDec++ >= 15)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///     Numeros, sin puntos
        ///     Maximo 30 caracteres
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nudNumero"></param>
        internal static void validarNumero(KeyPressEventArgs e, TextBox nudNumero)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            
            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                )
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///    Numeros, con puntos 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nudNumero"></param>
        internal static void validarNumeroConDecimales(KeyPressEventArgs e, TextBox nudNumero)
        {
            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                )
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Permite que en una textbox se puedan ingresar:
        ///    Numeros, sin puntos, hasta un máximo de dígitos indicado 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nudNumero"></param>
        /// <param name="digitos"></param>
        internal static void validarNumeroMaximoDigitos(KeyPressEventArgs e, TextBox nudNumero, int digitos)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }

            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != (char)Keys.Delete)
                )
            {
                e.Handled = true;
                return;
            }

            int nroDec = 1;

            for (int i = 0; i < nudNumero.Text.Length; i++)
            {
                if (nroDec++ >= digitos)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
