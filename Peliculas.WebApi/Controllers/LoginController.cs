using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Entidades;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Peliculas.WebApi.Controllers
{

    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserLoginService _userLogingService;
        private readonly IConfiguration _config;

        public LoginController(IMapper mapper,
                               IUserLoginService userLogingService,
                               IConfiguration config)
        {
            _mapper = mapper;
            _userLogingService = userLogingService;
            _config = config;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("authenticate")]
        public async Task<IActionResult> Login(UserLoginDto login)
        {
            var userLogin = _mapper.Map<UserLogin>(login);

            var response = await _userLogingService.GetUserLogin(userLogin);

            if (response is null)
                return BadRequest(new { message = "Invalid credentials" });

            string jwtToken = GenerateToken(response);

            return Ok(new { token = jwtToken });
        }

        private string GenerateToken(UserLogin user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };

            //Leo la key (Secret)
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));
            //Genero la key digital asociada a las credenciales.
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            //Generamos el token.
            var securityToken = new JwtSecurityToken(
                                        claims: claims,
                                        expires: DateTime.Now.AddMinutes(60),
                                        signingCredentials: creds
                                    );
            //Lo transformo a string
            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return token;

        }
    }
}
