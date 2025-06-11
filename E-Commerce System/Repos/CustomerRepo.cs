using E_Commerce_System.DTOs.CustomerDTO;
using E_Commerce_System.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_System.Repos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }
        public GetCustomer GetCustomerById(int id)
        {
            var customer = _context.Customers.Include(x => x.Orders).ThenInclude(x => x.Products)
                .Include(x => x.ShoppingCart).FirstOrDefault(x=>x.Id == id);
            return new GetCustomer
            {
                Name = customer.Name,
                EmailAddress = customer.EmailAddress,
                Phone = customer.Phone,
                ShoppingCardOnly = new DTOs.ShoppingCardDTO.ShoppingCardOnly
                {
                    NumberOfItems = customer.ShoppingCart.NumberOfItems,
                },
                OrderOnly = customer.Orders.Select(x=>new DTOs.OrderDTO.OrderWithProduct
                {
                    Price = x.Price,
                    ProductOnly = x.Products.Select(x=> new DTOs.ProductDTO.ProductOnly
                    {

                        Name = x.Name,
                        Description = x.Description,
                        StockQuantity = x.StockQuantity,    
                    }).ToList(),
                }).ToList(),
            };
        }

        public void Post(PostCustomer postCustomer)
        {
            var customer = new Customer
            {
                Name = postCustomer.Name,
                EmailAddress = postCustomer.EmailAddress,
                Phone = postCustomer.Phone,
                Orders = postCustomer.OrderOnly.Select(x=> new Order
                {
                    Price = x.Price,
                }).ToList(),
                ShoppingCart = new ShoppingCart
                {
                    NumberOfItems = postCustomer.ShoppingCardOnly.NumberOfItems,
                }
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
}
