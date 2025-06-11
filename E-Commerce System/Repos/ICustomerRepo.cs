using E_Commerce_System.DTOs.CustomerDTO;

namespace E_Commerce_System.Repos
{
    public interface ICustomerRepo
    {
        void Post(PostCustomer postCustomer);
        GetCustomer GetCustomerById(int id);
    }
}
