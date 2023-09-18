using System.ComponentModel.DataAnnotations;

namespace LearnWithAbhi.Application.Model
{
	public class LoginModel
	{
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        //[Required]
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        //public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; } = string.Empty;

    }
}
