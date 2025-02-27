﻿using System.ComponentModel.DataAnnotations;

namespace CSharpNet8Login.Models
{
    public class RegistrationViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required.")]
        [MaxLength(50, ErrorMessage = "Max. 50 characters allowed.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MaxLength(50, ErrorMessage = "Max. 50 characters allowed.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(100, ErrorMessage = "Max. 100 characters allowed.")]
        [DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max. 20 characters allowed.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max. 20 or min. 5 characters allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and confirm password do not match.")]
        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}