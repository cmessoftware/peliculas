using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Mapeos
{
    internal class GenerosMapperProfile : Profile
    {
        public GenerosMapperProfile()
        {
                        
            CreateMap<Genero, GeneroViewModel>();
        }
    }
}