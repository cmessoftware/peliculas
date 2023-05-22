using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioComentarios : IServicioGenerico<Comentario>
    {
        Task<bool> Create(Comentario comentario);

        Task<List<Comentario>> GetAll();

        Task<Comentario> GetById(int? id);

        Task<bool> Update(Comentario comentario);

        Task<bool> Delete(Comentario com);
    }
}
