using E_Commerce_System.DTOs.OrderDTO;
using E_Commerce_System.Models;
using E_Commerce_System.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _repo;

        public OrderController(IOrderRepo orderRepo)
        {
            _repo = orderRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _repo.GetAll();
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
        [HttpPost]
        public IActionResult Post(PostOrder dto)
        {
           var order= _repo.Post(dto);
            if (order == "false")
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           var r= _repo.Delete(id);
            if (r == "false")
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id , UpdateOrder dto)
        {
            var o = _repo.Update(id, dto);
            if (o == "false")
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
