using System.ComponentModel.DataAnnotations;

namespace Excell_On_Service.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string ClientName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string ClientEmail { get; set; } = string.Empty;

        public string ClientPhoto { get; set; } = string.Empty;
        [Required]
        public string ClientAddress { get; set; } = string.Empty;
        [Required]
        public string ClientPhone { get; set; } = string.Empty;
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string ClientPassword { get; set; } = string.Empty;
        [Required]
        [Compare("ClientPassword")]
        [DataType(DataType.Password)]
        public string ClientCPassword { get; set; } = string.Empty;
    }
}
