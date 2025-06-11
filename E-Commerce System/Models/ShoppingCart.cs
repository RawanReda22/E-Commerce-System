using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ?NumberOfItems { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }

    }
}
