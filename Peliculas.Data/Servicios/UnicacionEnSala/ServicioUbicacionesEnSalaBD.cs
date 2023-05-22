using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioUbicacionesEnSala : IServicioUbicacionesEnSala
    {
        public IUnitOfWork _unitOfWork;

        public ServicioUbicacionesEnSala(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(UbicacionEnSala ubicacionEnSala)
        {
            if (ubicacionEnSala != null)
            {
                await _unitOfWork.UbicacionesEnSala.Create(ubicacionEnSala);

                var result = _unitOfWork.SaveChanges();

                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                await _unitOfWork.UbicacionesEnSala.Delete(id);
            }
            return false;
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UbicacionEnSala>> GetAll()
        {
            var ubicacionesEnSala = await _unitOfWork.UbicacionesEnSala.GetAll();
            return ubicacionesEnSala;
        }

        public async Task<UbicacionEnSala> GetById(int? id)
        {
            if (id != null)
            {
                var ubicacionEnSala = await _unitOfWork.UbicacionesEnSala.GetById(id);
                if (ubicacionEnSala != null)
                {
                    return ubicacionEnSala;
                }
            }
            return null;
        }

        public async Task<bool> Update(UbicacionEnSala ubicacionEnSala)
        {
            if (ubicacionEnSala != null)
            {
                var ubicacionEnSalaDB = await _unitOfWork.UbicacionesEnSala.GetById(ubicacionEnSala.Id);
                if (ubicacionEnSalaDB != null)
                {
                    //comentarioDB.Contenido = ubicacionEnSala.Contenido;
                    //comentarioDB.Usuario = ubicacionEnSala.Usuario;

                    await _unitOfWork.UbicacionesEnSala.Update(ubicacionEnSalaDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
