using Movies.WebApi.Entities;
using System.Linq;

namespace Movies.Common.Helpers
{
    public class Utils
    {
        public static string EncryptData(string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene las acciones que puede realizar en cada entidad segun rol
        /// TODO: Tomar la identid del usuario.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetActions(string entidad, User user = null)
        {
            return new List<string> { "|editar", "|borrar" };
        }

        public static bool ListCheck<T>(IList<T> l1, IList<T> l2)
        {
            if (l1 == null || l2 == null)
                return false;

            if (l1.Intersect(l2).Any())
            {
                //Console.WriteLine("matched");
                return true;
            }
            else
            {
                //Console.WriteLine("not matched");
                return false;
            }
        }

    }
}
