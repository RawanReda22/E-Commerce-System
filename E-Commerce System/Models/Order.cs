using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ?Price { get; set; }
        public Customer ?Customer { get; set; }
        public int? CustomerId { get; set; }
        public List<Product> ?Products { get; set; }
    }
}
