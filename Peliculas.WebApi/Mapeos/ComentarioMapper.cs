using AutoMapper;
using Peliculas.WebApi.Entidades;
using Peliculas.WebApi.Dto;

namespace Peliculas.WebApi.Mapeos
{
    public class ComentarioMapper : IComentarioMapper
    {
        private readonly IMapper _mapper;

        public ComentarioMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ComentarioDto> Map(List<Comentario> entity)
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