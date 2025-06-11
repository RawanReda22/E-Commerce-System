using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        public int? StockQuantity { get; set;}
        public List<Order>? Orders { get; set; }

    }
}
