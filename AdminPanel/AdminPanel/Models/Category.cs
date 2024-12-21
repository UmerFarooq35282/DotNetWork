using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        [StringLength(50) , MinLength(3)]
        public string CategoryName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Category Slug")]
        [StringLength(10), MinLength(3)]
        public string Slug { get; set; } = string.Empty;

    }
}
