namespace Movies.Common.Helpers
{
    public interface ITokenConfigManager
    {
        string Audience { get; }
        string Issuer { get; }
        string Key { get; }
        IConfigurationSection GetConfigurationSection(string Key);
    }
}