using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace CrudWithMvc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } 
        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50)]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Product Description")]
        [StringLength(50)]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product Price")]
        public int Price { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product Quantity")]
        public int ProductQuantity { get; set; }

        [Required]
        public string Slug { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
