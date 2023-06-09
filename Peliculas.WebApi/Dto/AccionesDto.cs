namespace Peliculas.Web.Dto
{
    public class AccionesDto
    {
        /// <summary>
        /// Lista de accones que puede ejecuar un usuario para el modelo determinado.
        /// Mejora: Asociar a un enum y manejarse con enteros.
        /// </summary>
        public List<string> Acciones { get; set; }
    }
}