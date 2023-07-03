namespace Movies.Common.Helpers
{
    public class TokenConfigManager : ITokenConfigManager
    {
        private readonly IConfiguration _configuration;
        public TokenConfigManager(IConfiguration configuration)
        {
            _configuration = configuration;
            //_configuration = new ConfigurationBuilder()
            //.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //.Build();
        }

        public string Issuer => _configuration["Jwt:Issuer"];

        public string Audience => _configuration["Jwt:Audience"];

        public string Key => _configuration["Jwt:Key"];
        public IConfigurationSection GetConfigurationSection(string Key)
        {
            return this._configuration.GetSection(Key);
        }
    }
}