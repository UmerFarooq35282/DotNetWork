using System.ComponentModel.DataAnnotations;

namespace LoginTemplate.Models
{
    public class LoginUser
    {
        [Key]
        [Required]
        [StringLength(70)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [StringLength(30)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string CPassword { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
