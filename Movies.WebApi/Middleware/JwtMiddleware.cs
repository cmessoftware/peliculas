using Movies.WebApi.Authorization;

namespace Movies.WebApi.Middleware;


using Microsoft.Extensions.Options;
using Movies.Servicios;
using Movies.WebApi.Helpers;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    
    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        var userId = jwtUtils.ValidateJwtToken(token);
        if (userId != null)
        {
            // attach user to context on successful jwt validation
            context.Items["User"] = await userService.GetById(userId.Value);
        }

        await _next(context);
    }
}