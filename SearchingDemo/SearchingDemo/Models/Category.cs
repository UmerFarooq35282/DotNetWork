using System.ComponentModel.DataAnnotations;

namespace SearchingDemo.Models
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }

        [Required]
        public string CategoryName { get; set; } = string.Empty;
    }

}
