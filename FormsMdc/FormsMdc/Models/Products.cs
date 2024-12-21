using System.ComponentModel.DataAnnotations;

namespace FormsMdc.Models
{

    public enum ProductType
    {
        Tablet,
        Suspension,
        Syrup
    }
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name required")]
        [StringLength(50, ErrorMessage = "Maximum 50 Char Allowed"), MinLength(3, ErrorMessage = "Min 3 Character Allowed ")]
        public string ProductName { get; set; } = string.Empty;

        public ProductType ProductType { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public Companies Companies { get; set; }
    }
}
