using System.ComponentModel.DataAnnotations;

namespace Group15.EventManager.Shared.Auth
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "This is not a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must provide a password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
