using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.CustomerDTO
{
    public class CustomerOnly
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
    }
}
