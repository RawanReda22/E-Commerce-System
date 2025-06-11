using E_Commerce_System.DTOs.OrderDTO;
using E_Commerce_System.DTOs.ShoppingCardDTO;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.CustomerDTO
{
    public class PostCustomer
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        
        public ShoppingCardOnly ?ShoppingCardOnly { get; set; }
        public List<OrderOnly> ?OrderOnly { get; set; }
    }
}
