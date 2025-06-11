using E_Commerce_System.DTOs.ProductDTO;
using E_Commerce_System.Models;

namespace E_Commerce_System.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Post(ProductOnly productOnly)
        {
            var product = new Product
            {
                Description = productOnly.Description,
                Name = productOnly.Name,
                StockQuantity = productOnly.StockQuantity,
            };
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
