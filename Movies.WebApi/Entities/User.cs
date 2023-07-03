using Microsoft.AspNetCore.Identity;
using Movies.Web.Enums;
using System.ComponentModel.DataAnnotations;

namespace Movies.WebApi.Entities
{
    public class User : IdentityUser<int>
    {
        public int Id { get; set; }

        public string IdentificationNumber { get; set; }

        public EnumStatus Status { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Role> Roles { get; set; }
    }
}
