using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Common.Utils
{
    public class Utils
    {
        public static string EncryptData(string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene las acciones que puede realizar en cada entidad segun rol
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAcciones(string entidad, UserDto user)
        {
            return new List<string> { "|editar", "|borrar" };
        }

        public static UserLogin Login(string userName, string encriptedPssword)
        {
            throw new NotImplementedException();
        }
    }
}
