namespace Peliculas.WebApi.Controllers
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; internal set; }
    }
}