using System.ComponentModel.DataAnnotations;

namespace MDCForms.Models
{
    public enum DistType
    {
        Medicine,
        General
    }
    public class Companies
    {
        [Key]

        [Required(ErrorMessage = ("Distributor Name Required"))]
        [Display(Name = "Distributor Name")]
        [StringLength(40), MinLength(3)]
        public string CompanyName { get; set; } = string.Empty;

        [Display(Name = "Distributor Type ")]
        public DistType DistType { get; set; }
    }

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
