using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWeb.Models
{
    [Table("TblAdminReg")]
    public class AdminReg
    {
        [Key]
        public int Aid { get; set; }
        [Required(ErrorMessage = "Enter Your First Name")]
        [Display(Name = "First Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Enter Your Last Name")]
        [Display(Name = "Last Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Type your email id")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(20, ErrorMessage = "Mar 20 char allowed")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20, ErrorMessage = "Max 20 Char Allowed")]
        [MinLength(5, ErrorMessage = "Must be 5 char")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20, ErrorMessage = "Max 20 Char Allowed")]
        [MinLength(5, ErrorMessage = "Must be 5 char")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password Not Matched")]
        public string CPassword { get; set; }
    }
    [Table("TblAppointment")]
    public class Appointment
    {
        [Key]
        public int ApId { get; set; }
        [Required(ErrorMessage = "Enter Your First Name")]
        [Display(Name = "First Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Enter Your Last Name")]
        [Display(Name = "Last Name ")]
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Type Your Contact No")]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        
        [Display(Name = "Choose Date For Appointment")]
        [DataType(DataType.Date)]
        public string ADate { get; set; }

        [Display(Name = "Choose Time For Appointment")]
        public string ATime { get; set; }
    }
    [Table("TblQuery")]
    public class Query
    {
        public int QueryId { get; set; }
        [Required(ErrorMessage = "Enter Your First Name")]        
        [MaxLength(40, ErrorMessage = "Max 40 Char Allowed")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Type your email id")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(20, ErrorMessage = "Mar 20 char allowed")]
        public string Email { get; set; }

        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Enter Your Question Here")]
        [MaxLength(300, ErrorMessage = "Max 300 Char Allowed")]
        public string Question { get; set; }

    }

}
