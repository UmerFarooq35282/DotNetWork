using System.ComponentModel.DataAnnotations;

namespace Excell_On_Service.Models
{
    public class PymentDetail
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        [StringLength(10)]
        public string CardType { get; set; } = string.Empty;
        [Required]
        [MinLength(16, ErrorMessage = "Card Not Found")]
        public string CardNumber { get; set; } = string.Empty;
        [Required]
        [MinLength(3, ErrorMessage = "CVV Must contain 3 digit"), MaxLength(3, ErrorMessage = "CVV Must contain 3 digit")]
        public string CardCvv { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        [MinLength(10) , MaxLength(10)]
        public string Phone { get; set; } = string.Empty;
        public int ClientId { get; set; }
        public Client ClientsDetail { get; set; }
    }
}
