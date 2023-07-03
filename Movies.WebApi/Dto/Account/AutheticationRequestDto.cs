using System.ComponentModel.DataAnnotations;

public class AuthenticateRequestDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}