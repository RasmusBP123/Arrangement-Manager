using System.ComponentModel.DataAnnotations;

namespace Group15.EventManager.Application.ViewModels.Auth
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
