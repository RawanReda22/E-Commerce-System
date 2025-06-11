using E_Commerce_System.DTOs.ProductDTO;
using E_Commerce_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo productRepo)
        {
            _repo = productRepo;
        }
        [HttpPost]
        public IActionResult Post(ProductOnly dto)
        {
             _repo.Post(dto);
            return Ok();
        }
    }
}
