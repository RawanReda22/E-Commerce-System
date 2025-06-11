using System.ComponentModel.DataAnnotations;

namespace E_Commerce_System.DTOs.ShoppingCardDTO
{
    public class ShoppingCardOnly
    {
        [Required]
        public int? NumberOfItems { get; set; }
    }
}
