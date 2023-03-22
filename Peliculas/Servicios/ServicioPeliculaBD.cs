using AutoMapper;

using Azure;

using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.Mapeos;
using Peliculas.Repositorio;

namespace Peliculas.Servicios
{
    public class ServicioPeliculaBD : IServicioPelicula
    {
        private readonly ILogger<ServicioPeliculaBD> _logger;
        private readonly IMapper _mapper;
        private readonly IRepositorioPelicula _repo;

        public ServicioPeliculaBD( ILogger<ServicioPeliculaBD> logger,
                              IMapper mapper,
                              IRepositorioPelicula repo )
        {
            _logger = logger;
            _mapper = mapper;
            _repo = repo;
        }

        public void ActualizarComentarioLike(ComentarioDto? comentario, string idLike)
        {
            throw new NotImplementedException();
        }

        public PeliculaDto CrearPelicula(PeliculaDto pelicula)
        {
            throw new NotImplementedException();
        }

      
        public async Task<PeliculaDto> GetPeliculaEstrenoById(int id)
        {
            var pelicula = await _repo.GetPeliculaEstrenoById(id);

            var peliculaDto = _mapper.Map<PeliculaDto>(pelicula);

            return peliculaDto;

        }

        public async Task<List<PeliculaDto>> GetPeliculasEstreno()
        {
            List<Pelicula> peliculas = await _repo.GetPeliculasEstreno ();
            List<PeliculaDto> peliculasDto =new List<PeliculaDto>();
            foreach (var item in peliculas)
            {
                PeliculaDto peliDto = new PeliculaDto ();
                peliDto = _mapper.Map<PeliculaDto> ( item );
                peliculasDto.Add ( peliDto);
           }
            

            return peliculasDto;
        }

        public void InsertarPelicula(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

    }
}
