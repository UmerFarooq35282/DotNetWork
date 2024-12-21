using System.ComponentModel.DataAnnotations;

namespace CrudWithAjax.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string State { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;
        [Required]
        public int Salary { get; set; } = 0;

    }
}
