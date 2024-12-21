using System.ComponentModel.DataAnnotations;

namespace PracticeToMVCCore.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(3 , ErrorMessage = "Minimum 3 Charactor Required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(3, ErrorMessage = "Minimum 3 Charactor Required")]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(200)]
        [MinLength(3, ErrorMessage = "Minimum 3 Charactor Required")]
        public string Address { get; set; }
    }
}
