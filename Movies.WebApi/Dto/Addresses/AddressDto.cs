using Newtonsoft.Json;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Dto;

public partial class AddressDto
{
    [JsonIgnore]
    public int Id { get; set; }

    public int Country { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int Number { get; set; }

    public string ZipCode { get; set; } = null!;
}
