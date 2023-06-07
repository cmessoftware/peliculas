using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioSalasCine : IServicioSalasCine
    {
        public IUnitOfWork _unitOfWork;

        public ServicioSalasCine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(SalasCine salaCine)
        {
            if (salaCine != null)
            {
                await _unitOfWork.SalasDeCine.Create(salaCine);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                return await _unitOfWork.SalasDeCine.Delete(id);
            }
            return false;
        }

        public Task<bool> Delete(SalasCine salaCine)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SalasCine>> GetAll()
        {
            var salaCine = await _unitOfWork.SalasDeCine.GetAll();
            return salaCine;
        }

        public async Task<SalasCine> GetById(int? id)
        {
            if (id != null)
            {
                var salaCine = await _unitOfWork.SalasDeCine.GetById(id);
                if (salaCine != null)
                {
                    return salaCine;
                }
            }
            return null;
        }

        public async Task<bool> Update(SalasCine sc)
        {
            if (sc != null)
            {
                var salaCineBD = await _unitOfWork.SalasDeCine.GetById(sc.Id);
                if (salaCineBD != null)
                {
                    //comentarioDB.Contenido = sc.Contenido;
                    //comentarioDB.Usuario = sc.Usuario;

                    await _unitOfWork.SalasDeCine.Update(salaCineBD);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
