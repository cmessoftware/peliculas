using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Repositorio;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioPeliculasActores : IServicioPeliculasActores
    {
        public IUnitOfWork _unitOfWork;

        public ServicioPeliculasActores(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(PeliculaActor peliculaActor)
        {
            if (peliculaActor != null)
            {
                await _unitOfWork.PeliculasActores.Create(peliculaActor);

                var result = _unitOfWork.SaveChanges();

                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                var peliculaActor = await _unitOfWork.PeliculasActores.GetById(id);
                if (peliculaActor != null)
                {
                    return await _unitOfWork.PeliculasActores.Delete(id);
                }
            }
            return false;
        }
        
        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PeliculaActor>> GetAll()
        {
            var peliculaActor = await _unitOfWork.PeliculasActores.GetAll();
            return peliculaActor;
        }

        public async Task<PeliculaActor> GetById(int? id)
        {
            if (id > 0)
            {
                var peliculaActor = await _unitOfWork.PeliculasActores.GetById(id);
                if (peliculaActor != null)
                {
                    return peliculaActor;
                }
            }
            return null;
        }

        public async Task<bool> Update(PeliculaActor peliculaActor)
        {
            if (peliculaActor != null)
            {
                var peliculaActorBD = await _unitOfWork.PeliculasActores.GetById(peliculaActor.Id);
                if (peliculaActorBD != null)
                {
                    //peliculaActorBD.Contenido = peliculaActor.Contenido;
                    //peliculaActorBD.Usuario = peliculaActor.Usuario;

                    await _unitOfWork.PeliculasActores.Update(peliculaActorBD);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
