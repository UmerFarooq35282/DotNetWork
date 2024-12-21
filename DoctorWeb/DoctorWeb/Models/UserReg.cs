
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoctorWeb.Models
{
    public enum Gender
    {
        Male, Female
    }
    [Table("TblUserReg")]
    public class UserReg
    {
        [Key]
        public int Rid { get; set; }
        [Required(ErrorMessage = "Enter Your First Name")]
        [Display(Name = "First Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Enter Your Last Name")]
        [Display(Name = "Last Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string LName { get; set; }
        [Display(Name = "Gender")]
        public Gender Gend { get; set; }
        [Required(ErrorMessage = "Type Your Contact No")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Type your email id")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(20, ErrorMessage = "Mar 20 char allowed")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Your Address")]
        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "Max 200 Char Allowed")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Your Specialization field")]
        [Display(Name = "Specialization Field")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string Field { get; set; }
        [Required(ErrorMessage = "Enter Your Specialization field")]
        [Display(Name = "Professional Field")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Enter Your Qualification")]
        [Display(Name = "Qualification")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Enter Your experience")]
        [Display(Name = "No of year experience")]
        [MaxLength(10, ErrorMessage = "Max 10 Char Allowed")]
        public string Experience { get; set; }
        [Required(ErrorMessage = "Enter Your achievement")]
        [Display(Name = "First Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string achievement { get; set; }
        [Required(ErrorMessage = "Enter Your Locatio")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20, ErrorMessage = "Max 20 Char Allowed")]
        [MinLength(5 , ErrorMessage = "Must be 5 char")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20, ErrorMessage = "Max 20 Char Allowed")]
        [MinLength(5, ErrorMessage = "Must be 5 char")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password" , ErrorMessage = "Password Not Matched")]
        public string CPassword { get; set; }
        [Display(Name = "Upload Image")]
        public string Image {  get; set; }

    }
}
