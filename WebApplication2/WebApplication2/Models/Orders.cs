using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
