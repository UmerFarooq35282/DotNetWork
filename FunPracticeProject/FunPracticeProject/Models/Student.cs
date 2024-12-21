using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FunPracticeProject.Models
{
    public enum Gender
    {
        Male , Female
    }
    public class Student
    {
        public int id { get; set; }
        [Required(ErrorMessage="Name is Required For this field")]
        [Display(Name = "Student Name ")]
        [StringLength(100 , ErrorMessage ="Maximum 100 Charactar allowed")]
        public string SName { get; set; }
        [Required(ErrorMessage = "Father Name is Required For this field")]
        [Display(Name = "Father Name ")]
        [StringLength(100, ErrorMessage = "Maximum 100 Charactar allowed")]
        public string FName { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Student Class is Required For this field")]
        [Display(Name = "Student Class")]
        [StringLength(10, ErrorMessage = "Maximum 10 Charactar allowed")]
        public string SClass { get; set; }
        [Required(ErrorMessage = "Student Address is Required For this field")]
        [Display(Name = "Student Address")]
        [StringLength(200, ErrorMessage = "Maximum 200 Charactar allowed")]
        public string SAddress { get; set; }
    }
}
