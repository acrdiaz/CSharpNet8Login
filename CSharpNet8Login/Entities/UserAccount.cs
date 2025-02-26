using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CSharpNet8Login.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required.")]
        [MaxLength(50, ErrorMessage = "Max. 50 charactesr allowed.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MaxLength(50, ErrorMessage = "Max. 50 charactesr allowed.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(100, ErrorMessage = "Max. 100 charactesr allowed.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max. 20 charactesr allowed.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(20, ErrorMessage = "Max. 20 charactesr allowed.")]
        public string Password { get; set; }
    }
}
