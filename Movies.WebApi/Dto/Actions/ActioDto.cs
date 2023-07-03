namespace Movies.WebApi.Dto.Acciones
{
    public record ActioDto
    {
        /// <summary>
        /// Lista de accones que puede ejecuar un usuario para el modelo determinado.
        /// Mejora: Asociar a un enum y manejarse con enteros.
        /// </summary>
        public List<string> Actions { get; set; }
    }
}