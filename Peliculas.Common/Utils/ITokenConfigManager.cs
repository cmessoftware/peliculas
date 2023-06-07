using Microsoft.Extensions.Configuration;

namespace Peliculas.Common.Utils
{
    public interface ITokenConfigManager
    {
        string Audience { get; }
        string Issuer { get; }
        string Key { get; }
        IConfigurationSection GetConfigurationSection(string Key);
    }
}