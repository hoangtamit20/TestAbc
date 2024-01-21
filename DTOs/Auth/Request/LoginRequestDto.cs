using System.ComponentModel.DataAnnotations;

namespace OCLP.DTOs.Auth.Request
{
    public class LoginRequestDto
    {
        [Required]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}