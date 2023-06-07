namespace Peliculas.Common.Utils
{
    public interface ITokenManager
    {
        string GenerateToken(string username);
        string ValidateToken(string token);

    }
}