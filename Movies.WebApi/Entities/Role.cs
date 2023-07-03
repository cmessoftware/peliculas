using Microsoft.AspNetCore.Identity;

namespace Movies.WebApi.Entities
{
    public class Role : IdentityRole<int>
    {
        public int Id { get; set; }
        public string? Description { get; set; }
    }
}