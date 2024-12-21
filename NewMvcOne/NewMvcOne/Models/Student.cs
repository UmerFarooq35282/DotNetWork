using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewMvcOne.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName" , TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column("StudentGender", TypeName = "varchar(20)")]
        public string Gender { get; set; }
        [Column("StudentAge")]
        public int Age { get; set; }
        [Column("StudentEmail", TypeName = "varchar(100)")]

        public string Email { get; set; }
        [Column("StudentPhone", TypeName = "varchar(100)")]
        public string? Phone { get; set; }

    }
}
