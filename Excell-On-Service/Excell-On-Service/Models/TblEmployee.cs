using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Excell_On_Service.Models
{
    public class TblEmployee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string CPassword { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        [Required]
        public string RoleEmploye { get; set; } = string.Empty;
        public float Salary { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public Service? Service { get; set; }

    }

    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
