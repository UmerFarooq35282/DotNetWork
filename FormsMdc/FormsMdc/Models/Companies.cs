using System.ComponentModel.DataAnnotations;

namespace FormsMdc.Models
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
}
