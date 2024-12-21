using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcLoginPage.Models
{
    public class UserLogin
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage = "Password Not Matched")]
        public string CPassword { get; set; } = string.Empty;

        [Required]
        [StringLength (50)]
        [Display(Name = "User Name ")]
        public string UserName { get; set; } = string.Empty; 

    }
}
