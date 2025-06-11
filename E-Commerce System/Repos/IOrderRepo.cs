using E_Commerce_System.DTOs.OrderDTO;

namespace E_Commerce_System.Repos
{
    public interface IOrderRepo
    {
        IEnumerable<GetOrder> GetAll();
        string Post(PostOrder postOrder);
        string Delete(int id);
        string Update(int id , UpdateOrder updateOrder);
    }
}
