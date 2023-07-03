using Microsoft.AspNetCore.Identity;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Authorization;

public interface IJwtUtils
{
    string GenerateJwtToken(User user);
    int? ValidateJwtToken(string token);
}