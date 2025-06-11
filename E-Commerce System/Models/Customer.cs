using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public List<Order>? Orders { get; set; }
     //   public int ?ShoppingCardId { get; set; }
        public ShoppingCart ?ShoppingCart { get; set; }
    }
}
