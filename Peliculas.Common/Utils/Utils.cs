using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Common.Utils
{
    public class Utils
    {
        /// <summary>
        /// Obtiene las acciones que puede realizar en cada entidad segun rol
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAcciones(string entidad) 
        {
            return new List<string> { "editar", "borrar" };
        }
    }
}
