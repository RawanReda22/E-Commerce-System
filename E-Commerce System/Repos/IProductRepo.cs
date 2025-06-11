using E_Commerce_System.DTOs.ProductDTO;

namespace E_Commerce_System.Repos
{
    public interface IProductRepo
    {
        void  Post(ProductOnly productOnly);
    }
}
