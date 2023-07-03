using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public class ServicioComentarios : IServicioComentarios
    {
        public IUnitOfWork _unitOfWork;

        public ServicioComentarios(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Comments comentario)
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

        public async Task<List<Comments>> GetAll()
        {
            var comentarios = await _unitOfWork.Comentarios.GetAll();
            return comentarios;
        }

        public async Task<Comments> GetById(int? id)
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

        public async Task<bool> Update(Comments comentario)
        {
            if (comentario != null)
            {
                var comentarioDB = await _unitOfWork.Comentarios.GetById(comentario.Id);
                if (comentarioDB != null)
                {
                    comentarioDB.Content = comentario.Content;
                    comentarioDB.Client = comentario.Client;

                    await _unitOfWork.Comentarios.Update(comentarioDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
