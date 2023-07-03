using Newtonsoft.Json;
using Movies.Web.Enums;

namespace Movies.WebApi.Dto.Account
{
    public record UserDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int IdentificationNumber { get; set; }
        public EnumStatus Status { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<RoleDto> Roles { get; set; }
        public List<AddressDto> Addresses { get; set; }

    }
}