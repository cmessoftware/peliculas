using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public class ServicioComentarios : IServicioComentarios
    {
        public IUnitOfWork _unitOfWork;

        public ServicioComentarios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Comentario comentario)
        {
            if (comentario != null)
            {
                await _unitOfWork.Comentarios.Create(comentario);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                var comentario = await _unitOfWork.Comentarios.GetById(id);
                if (comentario != null)
                {
                    return await _unitOfWork.Comentarios.Delete(id);
                }
            }
            return false;
        }

        public async Task<List<Comentario>> GetAll()
        {
            var comentarios = await _unitOfWork.Comentarios.GetAll();
            return comentarios;
        }

        public async Task<Comentario> GetById(int? id)
        {
            if (id > 0)
            {
                var comentario = await _unitOfWork.Comentarios.GetById(id);
                if (comentario != null)
                {
                    return comentario;
                }
            }
            return null;
        }

        public async Task<bool> Update(Comentario comentario)
        {
            if (comentario != null)
            {
                var comentarioDB = await _unitOfWork.Comentarios.GetById(comentario.Id);
                if (comentarioDB != null)
                {
                    comentarioDB.Contenido = comentario.Contenido;
                    comentarioDB.Usuario = comentario.Usuario;

                    await _unitOfWork.Comentarios.Update(comentarioDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
