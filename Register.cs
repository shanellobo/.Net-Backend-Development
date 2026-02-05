using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name is Required")]
        [RegularExpression(@"^[A-Za-z]+$",
            ErrorMessage = "Name must contain only alphabets")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$",
            ErrorMessage = "password must be atleast 6 characters and contain at least one lowercase, one uppercase, one digit, one special character")]
        [MinLength(6, ErrorMessage = "Password must be atleast 6 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "age is Required")]
        [Range(18, 60, ErrorMessage = "age must be between 18 and 60")]
        public string Age { get; set; }

    }
}
