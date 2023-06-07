namespace Peliculas.WebApi.Mapeos
{
    public interface IGenericMapper<TDest, TSource>
    {
        List<TDest> Map(List<TSource> entity);
    }
}