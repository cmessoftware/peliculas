using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Web.Mapeos
{
    public interface IComentariosMapper
    {
        public List<ComentarioDto> Map(List<Comentario> comentario);
    }
}