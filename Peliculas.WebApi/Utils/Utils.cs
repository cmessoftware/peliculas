using Peliculas.WebApi.Entidades;
using Peliculas.WebApi.Dto;

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
        public static List<string> GetAcciones(string entidad, UserLoginDto user)
        {
            return new List<string> { "|editar", "|borrar" };
        }

        public static UserLogin Login(string userName, string encriptedPssword)
        {
            throw new NotImplementedException();
        }
    }
}
