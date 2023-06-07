using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioCineOfertas : IServicioCineOfertas
    {
        public IUnitOfWork _unitOfWork;

        public ServicioCineOfertas(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(CineOferta cineOferta)
        {
            if (cineOferta != null)
            {
                await _unitOfWork.CineOfertas.Create(cineOferta);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                var cineOferta = await _unitOfWork.CineOfertas.GetById(id);
                if (cineOferta != null)
                {
                    return await _unitOfWork.CineOfertas.Delete(id);
                }
            }
            return false;
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CineOferta>> GetAll()
        {
            var cineOfertas = await _unitOfWork.CineOfertas.GetAll();
            return cineOfertas;
        }

        public async Task<CineOferta> GetById(int? id)
        {
            if (id != null)
            {
                var cineOferta = await _unitOfWork.CineOfertas.GetById(id);
                if (cineOferta != null)
                {
                    return cineOferta;
                }
            }
            return null;
        }

        public async Task<bool> Update(CineOferta cineOferta)
        {
            if (cineOferta != null)
            {
                var cineOfertaDB = await _unitOfWork.CineOfertas.GetById(cineOferta.Id);
                if (cineOfertaDB != null)
                {
                    //cineOfertaDB.Contenido = cineOferta.Contenido;
                    //cineOfertaDB.Usuario = cineOferta.Usuario;

                    await _unitOfWork.CineOfertas.Update(cineOfertaDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }


    }
}
