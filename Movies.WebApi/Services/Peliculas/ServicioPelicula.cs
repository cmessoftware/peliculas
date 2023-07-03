using AutoMapper;
using Movies.Servicios.Peliculas;
using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
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

        public async Task<bool> Create(Movie pelicula)
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

        public async Task<List<Movie>> GetAll()
        {
            var peliculas = await _unitOfWork.Peliculas.GetAll();

            return peliculas;
        }

        public async Task<Movie> GetById(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);

                return pelicula;
            }
            return null;
        }

        public async Task<bool> Update(Movie pelicula)
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
