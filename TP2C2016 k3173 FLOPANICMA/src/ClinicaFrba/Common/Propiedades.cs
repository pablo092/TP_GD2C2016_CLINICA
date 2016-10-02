using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Common
{
    public class Propiedades
    {

        private static Dictionary<String, String> dictionary {get; set;}

        /// <summary>
        /// Retorna la ubicación del archivo de configuración
        /// StartupPath indica la raiz del proyecto. 
        ///     En tiempo de desarrollo, tener en cuenta que este archivo deberá ubicarse en la carpeta Debug, dentro de la carpeta bin
        /// </summary>
        private static String filename {get 
        {
            string path = Path.Combine(Application.StartupPath, "properties.txt");
            return path;       
            } 
        }

        /// <summary>
        /// Carga la configuración del archivo de configuración.
        /// Los renglones que empiecen con ; # ' = se ignorarán, permitiendo poner comentarios en los mismos
        /// El archivo deberá tener el formato CLAVE=VALOR
        /// </summary>
        /// <returns></returns>
        public static IDictionary ReadDictionaryFile()
        {
            dictionary = new Dictionary<string, string>();
            foreach (string line in File.ReadAllLines(filename))
            {
                if ((!string.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    string key = line.Substring(0, index).Trim();
                    string value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }
                    dictionary.Add(key, value);
                }
            }

            return dictionary;
        }
 
        /// <summary>
        /// Retorna la fecha actual desde el archivo de configuración
        /// La misma deberá tener el formto yyyy-MM-dd y estar con la clave FECHA
        /// </summary>
        public static DateTime getFechaActual { 
            get {
                if (dictionary == null)
                {
                    ReadDictionaryFile();
                }
                String fecha = dictionary["FECHA"];
                DateTime myDate = new DateTime();
                
                myDate = DateTime.ParseExact(fecha, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                
                return myDate;
            } 
        }
         
        /// <summary>
        /// Retorna el string de conexión.
        /// El mismo debe ser usado sólamente en la clase conexión.
        /// </summary>
        /// <returns></returns>
        public static String getStringConexion() {
            return "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Integrated Security=True";
        }

    }
}
