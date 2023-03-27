using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Servicios.Comentarios
{
    public interface IServicioComentarios
    {
        Task<bool> Create(Comentario comentario);

        Task<List<Comentario>> GetAll();

        Task<Comentario> GetById(int id);

        Task<bool> Update(Comentario comentario);

        Task<bool> Delete(int id);
    }
}
