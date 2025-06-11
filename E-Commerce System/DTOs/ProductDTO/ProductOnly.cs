using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.ProductDTO
{
    public class ProductOnly
    {
       
        [Required]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        public int? StockQuantity { get; set; }
    }
}
