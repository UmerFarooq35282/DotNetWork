using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramworkManual.Models
{
    public enum Gender
    {
        Male , Female , Others
    }
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName" , TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public  int Age { get; set; }
        [Required]
        [Column("StudentClass", TypeName = "varchar(50)")]
        public string Standard { get; set; }
    }
}
