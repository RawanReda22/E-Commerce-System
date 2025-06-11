using E_Commerce_System.DTOs.CustomerDTO;
using E_Commerce_System.DTOs.ProductDTO;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.OrderDTO
{
    public class GetOrder
    {
        [Required]
        public int? Price { get; set; }
        public List<ProductOnly> ?ProductOnly { get; set; }
        public CustomerOnly? CustomerOnly { get; set; }
    }
}
