using System.ComponentModel.DataAnnotations;

namespace FunProject02.Models
{
    public enum Gender
    {
        Male , Female
    }
    public class Student
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Student Name is required for this feiled")]
        [Display(Name ="Student Name")]
        [StringLength(100 , ErrorMessage = "Maximum 100 Charactar allowed ")]
        public string SName { get; set; }
        [Required(ErrorMessage = "Father Name is required for this feiled")]
        [Display(Name = "Father Name")]
        [StringLength(100, ErrorMessage = "Maximum 100 Charactar allowed ")]
        public string FName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Student Class is required for this feiled")]
        [Display(Name = "Student Class")]
        [StringLength(100, ErrorMessage = "Maximum 100 Charactar allowed ")]
        public string SClass { get; set; }
        [Required(ErrorMessage = "Student Address is required for this feiled")]
        [Display(Name = "Student Address")]
        [StringLength(100, ErrorMessage = "Maximum 100 Charactar allowed ")]
        public string SAddress { get; set; }

    }
}
