namespace Peliculas.Web.Dto
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; internal set; }
    }
}