using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Mapeos
{
    internal class MapeoCritica
    {

        internal static List<CriticaDto> Map(List<Critica> critica)
        {
            List<CriticaDto> criticaDto = new List<CriticaDto>();

            return criticaDto;
        }

        internal static CriticaDto Map(Critica critica)
        {
            CriticaDto criticaDto = new CriticaDto();


            return criticaDto;
        }
        internal static List<Critica> Map(List<CriticaDto> criticaDto)
        {
            List<Critica> critica = new List<Critica>();


            return critica;
        }


        internal static Critica Map(CriticaDto criticaDto)
        {
            Critica critica = new Critica();


            return critica;
        }
    }
}