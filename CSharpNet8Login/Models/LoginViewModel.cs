using System.ComponentModel.DataAnnotations;

namespace CSharpNet8Login.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max. 20 charactesr allowed.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max. 20 or min. 5 charactesr allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
