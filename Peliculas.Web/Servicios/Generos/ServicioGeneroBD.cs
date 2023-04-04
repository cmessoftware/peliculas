using AutoMapper;
using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Servicios.Generos;

namespace Peliculas.Web.Servicios.Generos
{
    public class ServicioGeneroDB : IServicioGeneros
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ServicioGeneroDB> _logger;

        public ServicioGeneroDB (IUnitOfWork unitOfWork,
                                  IMapper mapper,
                                  ILogger<ServicioGeneroDB> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Create(GeneroDto generoDto)
        {
            if (generoDto != null)
            {

                var genero = _mapper.Map<Genero>(generoDto);

                await _unitOfWork.Generos.Create(genero);

                return _unitOfWork.SaveChanges() > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int Id)
        {
            if (Id > 0)
            {
                var genero = await _unitOfWork.Generos.GetById(Id);
                if (genero != null)
                {
                    await _unitOfWork.Generos.Delete(genero );

                    return _unitOfWork.SaveChanges() > 0;
                }
            }
            return false;
        }

        public async Task<List<GeneroDto>> GetAll()
        {
            var generos = await _unitOfWork.Generos.GetAll();

            //TODO: Mejorar usando automapper Resolver.
            var generosDto = new List<GeneroDto>();

            foreach (var g in generos)
            {
                var generoDto = _mapper.Map<GeneroDto>(g);
                generosDto.Add(generoDto);
            }

            return generosDto;
        }

        public async Task<GeneroDto> GetById(int Id)
        {
            if (Id > 0)
            {
                var genero= await _unitOfWork.Generos.GetById(Id);
                if (genero != null)
                {
                    var generoDto = _mapper.Map<GeneroDto>(genero);
                    return generoDto;
                }
            }
            return null;
        }

        public async Task<bool> Update(GeneroDto generoDto)
        {
            if (generoDto != null)
            {
                var genero = await _unitOfWork.Generos.GetById(generoDto.Id);
                if (genero != null)
                {

                    genero = _mapper.Map<Genero>(generoDto );

                    await _unitOfWork.Generos.Update(genero);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
