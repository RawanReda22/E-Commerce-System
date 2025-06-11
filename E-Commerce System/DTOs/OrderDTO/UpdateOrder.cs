using E_Commerce_System.DTOs.ProductDTO;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.OrderDTO
{
    public class UpdateOrder
    {
        [Required]
        public int? Price { get; set; }
         
        public List<ProductOnly> ?products { get; set; }
    }
}
