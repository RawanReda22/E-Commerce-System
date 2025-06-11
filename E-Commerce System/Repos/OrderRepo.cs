using E_Commerce_System.DTOs.OrderDTO;
using E_Commerce_System.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_System.Repos
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;
        public OrderRepo(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public string Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
                return "true";
            }
            else
            {
                return "false";
            }
        }

        public IEnumerable<GetOrder> GetAll()
        {
            var order = _context.Orders.Include(x => x.Products).Include(x => x.Customer);
            return order.Select(x=> new GetOrder { 
              Price = x.Price,
              CustomerOnly = new DTOs.CustomerDTO.CustomerOnly
              {
                  Name = x.Customer.Name,
                  EmailAddress = x.Customer.EmailAddress,
                  Phone= x.Customer.Phone,
              },
              ProductOnly = x.Products.Select(x=> new DTOs.ProductDTO.ProductOnly
              {
                  Name = x.Name,
                  Description = x.Description,
                  StockQuantity = x.StockQuantity
              }).ToList(),
            }).ToList();
        }

        public string Post(PostOrder postOrder)
        {
            var x = _context.Customers.FirstOrDefault(x => x.Id == postOrder.CustomerId);
            if (x == null)
            {
                return "false";
            }
            else
            {
                var order = new Order
                {
                    Price = postOrder.Price,
                    Products = postOrder.ProductOnly.Select(x => new Product
                    {
                        Name = x.Name,
                        Description = x.Description,
                        StockQuantity = x.StockQuantity,
                    }).ToList(),

                    CustomerId = postOrder.CustomerId,
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
                return "true";
            }
            
           
        }

        public string Update(int id, UpdateOrder updateOrder)
        {
            var order = _context.Orders.Include(x=>x.Products).FirstOrDefault(y => y.Id == id);
            if(order != null)
            {
                order.Price = updateOrder.Price;
                order.Products = updateOrder.products.Select(x=> new Product
                {
                    Description = x.Description,
                    Name = x.Name,
                    StockQuantity= x.StockQuantity,
                }).ToList();
                _context.Orders.Update(order);
                _context.SaveChanges();
                return "true";
            }
            else
            {
                return "false";
            }

        }
    }
}
