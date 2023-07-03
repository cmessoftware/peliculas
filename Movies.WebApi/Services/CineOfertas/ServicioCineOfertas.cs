using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public class ServicioCineOfertas : IServicioCineOfertas
    {
        public IUnitOfWork _unitOfWork;

        public ServicioCineOfertas(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(CinemaOffer cineOferta)
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


        public async Task<List<CinemaOffer>> GetAll()
        {
            var cineOfertas = await _unitOfWork.CineOfertas.GetAll();
            return cineOfertas;
        }

        public async Task<CinemaOffer> GetById(int? id)
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

        public async Task<bool> Update(CinemaOffer cineOferta)
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
