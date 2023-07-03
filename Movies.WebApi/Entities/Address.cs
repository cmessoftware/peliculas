using Microsoft.AspNetCore.Identity;
using Movies.Web.Enums;

namespace Movies.WebApi.Entities;

public partial class Address
{
    public int Id { get; set; }

    public EnumCountry Country { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int Number { get; set; }

    public string ZipCode { get; set; } = null!;

    public int ClientId { get; set; }
    public Client? Client { get; set; }

}
