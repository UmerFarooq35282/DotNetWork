using System.ComponentModel.DataAnnotations;

namespace Excell_On_Service.Models
{
    public class TblCart
    {
        [Key]
        public int CartId { get; set; }

        public int SubServiceId { get; set; }
        public SubService SubService { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
