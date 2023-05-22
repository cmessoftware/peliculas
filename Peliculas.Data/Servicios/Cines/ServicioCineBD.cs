using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioCines : IServicioCines
    {
        public IUnitOfWork _unitOfWork;

        public ServicioCines(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Cine cine)
        {
            if (cine != null)
            {
                await _unitOfWork.Cines.Create(cine);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                var comentario = await _unitOfWork.Cines.GetById(id);
                if (comentario != null)
                {
                    return await _unitOfWork.Cines.Delete(id);
                }
            }
            return false;
        }

        public Task<bool> Delete(Cine cine)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cine>> GetAll()
        {
            var cines = await _unitOfWork.Cines.GetAll();
            return cines;
        }

        public async Task<Cine> GetById(int? id)
        {
            if (id > 0)
            {
                var cine = await _unitOfWork.Cines.GetById(id);
                if (cine != null)
                {
                    return cine;
                }
            }
            return null;
        }

        public async Task<bool> Update(Cine cine)
        {
            if (cine != null)
            {
                var cDB = await _unitOfWork.Cines.GetById(cine.Id);
                if (cDB != null)
                {
                    //cDB.Contenido = cine.Contenido;
                    //cDB.Usuario = cine.Usuario;

                    await _unitOfWork.Cines.Update(cDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
