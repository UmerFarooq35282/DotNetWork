using System.ComponentModel.DataAnnotations;

namespace SearchingDemo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;

        public int Categoryid { get; set; }

        public Category Category { get; set; }
    }
}
