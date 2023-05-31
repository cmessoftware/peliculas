using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.WebApi.Controllers
{
    public class CriticasMapper : ICriticasMapper
    {
        private readonly IMapper _mapper;

        public CriticasMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<CriticaDto> Map(List<Critica> criticas)
        {
            List<CriticaDto> criticaResponse = null;

            foreach (var com in criticas)
            {
                criticaResponse ??= new List<CriticaDto>();
                criticaResponse.Add(_mapper.Map<Critica, CriticaDto>(com));
            }

            return criticaResponse;
        }
    }
}