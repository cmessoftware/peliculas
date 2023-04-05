using AutoMapper;
using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios.Peliculas
{
    public class ServicioPeliculaDB : IServicioPelicula
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ServicioPeliculaDB> _logger;

        public ServicioPeliculaDB(IUnitOfWork unitOfWork,
                                  IMapper mapper,
                                  ILogger<ServicioPeliculaDB> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Create(PeliculaDto peliculaDto)
        {
            if (peliculaDto != null)
            {

                var pelicula = _mapper.Map<Pelicula>(peliculaDto);

                await _unitOfWork.Peliculas.Create(pelicula);

                return _unitOfWork.SaveChanges() > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int Id)
        {
            if (Id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(Id);
                if (pelicula != null)
                {
                    await _unitOfWork.Peliculas.Delete(pelicula);

                    return _unitOfWork.SaveChanges() > 0;
                }
            }
            return false;
        }

        public async Task<List<PeliculaDto>> GetAll()
        {
            var peliculas = await _unitOfWork.Peliculas.GetAll();

            //TODO: Mejorar usando automapper Resolver.
            var peliculasDto = new List<PeliculaDto>();

            foreach (var peli in peliculas)
            {
                var peliculaDto = _mapper.Map<PeliculaDto>(peli);
                peliculasDto.Add(peliculaDto);
            }

            return peliculasDto;
        }

        public async Task<PeliculaDto> GetById(int Id)
        {
            if (Id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(Id);
                if (pelicula != null)
                {
                    var peliculaDto = _mapper.Map<PeliculaDto>(pelicula);
                    return peliculaDto;
                }
            }
            return null;
        }

        public async Task<bool> Update(PeliculaDto peliculaDto)
        {
            if (peliculaDto != null)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(peliculaDto.Id);
                if (pelicula != null)
                {

                    pelicula = _mapper.Map<Pelicula>(peliculaDto);

                    await _unitOfWork.Peliculas.Update(pelicula);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
