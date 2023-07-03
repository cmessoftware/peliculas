using AutoMapper;
using Movies.WebApi.Dto;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    public class ActorMapper : IActorMapper
    {
        private readonly IMapper _mapper;

        public ActorMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ActorDto> Map(List<Actor> entity)
        {
            var ent = new List<ActorDto>();
            foreach (var item in entity)
            {
                var a = _mapper.Map<ActorDto>(item);
                ent.Add(a);
            }

            return ent;
        }

    }
}