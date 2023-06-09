using AutoMapper;
using Peliculas.Servicios.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public class ServicioPelicula : IServicioPelicula
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ServicioPelicula> _logger;

        public ServicioPelicula(IUnitOfWork unitOfWork,
                                IMapper mapper,
                                ILogger<ServicioPelicula> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Create(Pelicula pelicula)
        {
            if (pelicula != null)
            {
                await _unitOfWork.Peliculas.Create(pelicula);

                return _unitOfWork.SaveChanges() > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);
                if (pelicula != null)
                {
                    await _unitOfWork.Peliculas.Delete(id);

                    return _unitOfWork.SaveChanges() > 0;
                }
            }
            return false;
        }

        public async Task<List<Pelicula>> GetAll()
        {
            var peliculas = await _unitOfWork.Peliculas.GetAll();

            return peliculas;
        }

        public async Task<Pelicula> GetById(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);

                return pelicula;
            }
            return null;
        }

        public async Task<bool> Update(Pelicula pelicula)
        {
            if (pelicula != null)
            {
                var peliculaDto = await _unitOfWork.Peliculas.GetById(pelicula.Id);
                if (peliculaDto != null)
                {

                    await _unitOfWork.Peliculas.Update(pelicula);
                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }

    }
}
