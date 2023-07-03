using AutoMapper;
using Movies.WebApi.Dto.Criticas;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Controllers
{
    public class CriticaMapper : ICriticaMapper
    {
        private readonly IMapper _mapper;

        public CriticaMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<CriticaDto> Map(List<Critics> entity)
        {
            var ent = new List<CriticaDto>();
            foreach (var item in entity)
            {
                var a = _mapper.Map<CriticaDto>(item);
                ent.Add(a);
            }

            return ent;
        }
    }
}