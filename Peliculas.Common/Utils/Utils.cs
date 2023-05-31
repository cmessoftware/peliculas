using Peliculas.Web.Dto;

namespace Peliculas.Common.Utils
{
    public class Utils
    {
        /// <summary>
        /// Obtiene las acciones que puede realizar en cada entidad segun rol
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAcciones(string entidad, UserDto user) 
        {
            return new List<string> { "|editar", "|borrar" };
        }
    }
}
