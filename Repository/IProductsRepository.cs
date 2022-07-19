using posexample.Models;

namespace posexample.Repository;

public interface IProductsRepository
{
    Task<List<ProductsDTO>> GetProducts();
}