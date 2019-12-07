using System.ComponentModel.DataAnnotations;

namespace Group15.EventManager.Shared.Auth
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "This is not a valid email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Text)]
        [MinLength(1, ErrorMessage = "First name cannot be empty")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [MinLength(1, ErrorMessage = "Last name cannot be empty")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [MinLength(8, ErrorMessage = "This is not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
