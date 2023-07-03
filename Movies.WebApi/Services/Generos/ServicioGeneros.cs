using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public class ServicioGeneros : IServicioGeneros
    {
        public IUnitOfWork _unitOfWork;

        public ServicioGeneros(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Gender genero)
        {
            if (genero != null)
            {
                return await _unitOfWork.Generos.Create(genero);
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                return await _unitOfWork.Generos.Delete(id);
            }
            return false;
        }


        public async Task<List<Gender>> GetAll()
        {
            var generos = await _unitOfWork.Generos.GetAll();
            return generos;
        }

        public async Task<Gender> GetById(int? id, int? peliculaId)
        {
            if (peliculaId > 0)
            {
                var genero = await _unitOfWork.Generos.GetById(id, peliculaId);
                return genero;
            }
            return null;
        }

        public async Task<Gender> GetById(int? id)
        {
            if (id > 0)
            {
                return await _unitOfWork.Generos.GetById(id);
            }

            return null;
        }

        public async Task<bool> Update(Gender genero)
        {
            if (genero != null)
            {
                var generosDB = await _unitOfWork.Generos.GetById(genero.Id);
                if (generosDB != null)
                {

                    return await _unitOfWork.Generos.Update(genero);
                }
            }
            return false;
        }
    }
}
