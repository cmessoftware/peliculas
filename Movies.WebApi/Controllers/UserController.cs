
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Servicios;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;
using Movies.WebApi.Migrations;
using System.Net;
using UserDto = Movies.WebApi.Dto.Account.UserDto;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService,
                          IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [AllowAnonymous]
    [HttpPost("[action]")]
    public async Task<IActionResult> Authenticate(AuthenticateRequestDto model)
    {
        var response = await _userService.Authenticate(model);
        return Ok(response);
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        // only admins can access other user records
        //var currentUser = (User)HttpContext.Items["User"];
        //if (id != currentUser.Id && currentUser.Role != Role.Admin)
        //    return Unauthorized(new { message = "Unauthorized" });

        var user = await _userService.GetById(id);
        return Ok(user);
    }

    [Authorize]
    [HttpPost("register")]
    public async Task<IActionResult> Create([FromBody] UserDto userDto)
    {
        if (ModelState.IsValid)
        {
            var user = _mapper.Map<User>(userDto);

            //Generate hash password before insert in data base.
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            await _userService.Create(user);
            return Ok(
                    new
                    {
                        datos = userDto,
                        estado = StatusCode((int)HttpStatusCode.OK),
                    });
        }
        else
            throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");

    }

    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpDelete("{id}")]
    //[ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int? id)
    {
        if (ModelState.IsValid)
        {
            if(await _userService.Delete(id))
                return Ok(
                    new
                    {
                           datos = $"The id {id} was deleted",
                           estado = StatusCode((int)HttpStatusCode.OK),
                    }); 
            else
                return BadRequest($"Id invalido");
        }
        else
            return BadRequest($"Id invalido");

    }
}