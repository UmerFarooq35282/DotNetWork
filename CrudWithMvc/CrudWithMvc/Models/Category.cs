using System.ComponentModel.DataAnnotations;

namespace CrudWithMvc.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50) , MinLength(3)]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(50) , MinLength(3)]
        public string Slug { get; set; }
    }
}
