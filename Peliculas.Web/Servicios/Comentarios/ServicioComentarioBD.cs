using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Repositorio;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios.Comentarios
{
    public class ServicioComentarioBD : IServicioComentarios
    {
        public IUnitOfWork _unitOfWork;

        public ServicioComentarioBD(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Comentario comentario)
        {
            if (comentario != null)
            {
                await _unitOfWork.Comentarios.Create(comentario);

                var result = _unitOfWork.SaveChanges();

                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(int Id)
        {
            if (Id > 0)
            {
                var comentario = await _unitOfWork.Comentarios.GetById(Id);
                if (comentario != null)
                {
                    await _unitOfWork.Comentarios.Delete(comentario);
                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }

        public async Task<List<Comentario>> GetAll()
        {
            var comentarios = await _unitOfWork.Comentarios.GetAll();
            return comentarios;
        }

        public async Task<Comentario> GetById(int Id)
        {
            if (Id > 0)
            {
                var comentario = await _unitOfWork.Comentarios.GetById(Id);
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
