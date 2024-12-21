using System.ComponentModel.DataAnnotations;

namespace AjaxLearning.Models
{
    public class Employe
    {
        [Key]
        public int EmployeId { get; set; }
        [Required]
        public string EmployeName { get; set; } = string.Empty;
        [Required]
        public string EmpCity { get; set; } = string.Empty;
        [Required]
        public string EmpCountry { get; set; } = string.Empty;
        [Required]
        public string EmpPhone { get; set; } = string.Empty;
        [Required]
        public string EmpImage { get; set; } = string.Empty;

    }
}
