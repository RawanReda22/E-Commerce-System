using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.OrderDTO
{
    public class OrderOnly
    {
        [Required]
        public int? Price { get; set; }
    }
}
