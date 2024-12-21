using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50), MinLength(3)]
        public string ProductName { get; set; } = string.Empty;[Required]

        [Display(Name = "Short Discription")]
        [StringLength(150), MinLength(3)]
        public string ProductDisc { get; set; } = string.Empty;

        [Display(Name = "Long Discription")]
        [StringLength(50), MinLength(3)]
        public string ProductLongDisc { get; set; } = string.Empty;

        [Display(Name = "Product Price")]
        
        public int ProductPrice { get; set; } 

        [Display(Name = "Quantity")]
        
        public int ProductQuantity { get; set; }

        [Display(Name = "Product Image")]
        [StringLength(50), MinLength(3)]
        public string? ProductImage { get; set; }

        [Display(Name = "Product Slug")]
        [StringLength(50), MinLength(3)]
        public string Slug { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
