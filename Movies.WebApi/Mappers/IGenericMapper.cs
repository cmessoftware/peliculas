namespace Movies.WebApi.Mappers
{
    public interface IGenericMapper<TDest, TSource>
    {
        List<TDest> Map(List<TSource> entity);
    }
}