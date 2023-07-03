namespace Movies.Common.Helpers
{
    public interface ITokenManager
    {
        string GenerateToken(string username);
        string ValidateToken(string token);

    }
}