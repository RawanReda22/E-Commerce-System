using E_Commerce_System.DTOs.CustomerDTO;
using E_Commerce_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;
       public CustomerController(ICustomerRepo customerRepo)
       {
        _repo = customerRepo;
       }

        [HttpPost]
        public IActionResult Post(PostCustomer dto)
        {
             _repo.Post(dto);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var c = _repo.GetCustomerById(id);
            if(c == null)
            {
                return BadRequest();
            }
            return Ok(c);
        }
    }
    
     
}
