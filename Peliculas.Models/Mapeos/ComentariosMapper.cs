using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Web.Mapeos
{
    public class ComentariosMapper : IComentariosMapper
    {
        private readonly IMapper _mapper;

        public ComentariosMapper(IMapper mapper)
        {
            _mapper = mapper;
        }


        public List<ComentarioDto> Map(List<Comentario> comentarios)
        {
            List<ComentarioDto> comentariosResponse = null;

            foreach (var com in comentarios)
            {
                comentariosResponse ??= new List<ComentarioDto>();
                comentariosResponse.Add(_mapper.Map<Comentario, ComentarioDto>(com));
            }

            return comentariosResponse;
        }
    }
}