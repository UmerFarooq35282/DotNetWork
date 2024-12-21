using System.ComponentModel.DataAnnotations;

namespace Excell_On_Service.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        public string ServiceName { get; set; } = string.Empty;

        public string? MainServiceImg { get; set; }
        [Required]
        public string ServiceDescription { get; set; } = string.Empty;

        [Required]
        public string ServiceCode { get; set; } = string.Empty;
        [Required]
        public int ServiceCharges { get; set; }
    }

    public class SubService
    {
        [Key]
        public int SubServiceId { get; set; }
        [Required]
        public string SubServiceName { get; set;} = string.Empty;
        [Required]
        public string ServiceImage { get; set; } = string.Empty;
        [Required]
        public string SubServiceDescription { get; set;} = string.Empty;
        [Required]
        public string SubServiceCode { get; set;} = string.Empty;
        [Required]
        public int SubServiceCharges { get;set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
