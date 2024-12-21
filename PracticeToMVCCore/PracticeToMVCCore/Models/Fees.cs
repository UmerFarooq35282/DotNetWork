using System.ComponentModel.DataAnnotations;

namespace PracticeToMVCCore.Models
{
    public class Fees
    {
        public int Id { get; set; }
        [Display(Name = "Fee Month")]
        public string FMonth { get; set; }
        [Display(Name = "Fee Date")]
        public DateTime FDate { get; set; }
        [Display(Name = "Student Or Roll No")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
