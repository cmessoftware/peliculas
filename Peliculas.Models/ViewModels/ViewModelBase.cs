namespace Peliculas.Web.ViewModels
{
    public class ViewModelBase
    {
        /// <summary>
        /// Lista de accones que puede ejecuar un usuario para el modelo determinado.
        /// Mejora: Asociar a unj enum y manejarse con enteros.
        /// </summary>
        public List<string> Acciones { get; set; }
    }
}