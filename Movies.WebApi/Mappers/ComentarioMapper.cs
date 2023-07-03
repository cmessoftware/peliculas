using AutoMapper;
using Movies.WebApi.Dto;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    public class ComentarioMapper : IComentarioMapper
    {
        private readonly IMapper _mapper;

        public ComentarioMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ComentarioDto> Map(List<Comments> entity)
        {
            var ent = new List<ComentarioDto>();
            foreach (var item in entity)
            {
                var a = _mapper.Map<ComentarioDto>(item);
                ent.Add(a);
            }

            return ent;
        }

    }
}