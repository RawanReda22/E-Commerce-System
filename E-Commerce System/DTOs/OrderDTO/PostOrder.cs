using E_Commerce_System.DTOs.ProductDTO;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.OrderDTO
{
    public class PostOrder
    {
        [Required]
        public int? Price { get; set; }
        public List<ProductOnly> ?ProductOnly { get; set; }
        public int? CustomerId { get; set; }
    }
}
