using E_Commerce_System.DTOs.OrderDTO;
using E_Commerce_System.DTOs.ProductDTO;
using E_Commerce_System.DTOs.ShoppingCardDTO;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.CustomerDTO
{
    public class GetCustomer
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public ShoppingCardOnly? ShoppingCardOnly { get; set; }
        public List<OrderWithProduct>? OrderOnly { get; set; }
       // public List<OrderWithProduct>? ProductOnly { get; set; }
    }
}
