using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Models
{
    public class PanelUsers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string CPassword { get; set; } = string.Empty;
    }
}
