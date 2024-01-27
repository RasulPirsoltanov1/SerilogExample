using System.ComponentModel.DataAnnotations;

namespace Serilog.Business.DTO_s
{
    public class LoginDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
