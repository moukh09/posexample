
using posexample.Models;

namespace posexample.Repository;

public class ProductsRepository : IProductsRepository
{

    private readonly IConfiguration _configuration;
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductsRepository(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task<List<ProductsDTO>> GetProducts()
    {
        using (HttpClient client = _httpClientFactory.CreateClient())
        {

            var uri = new Uri($"{_configuration["ApiEndpoints:BaseEndpoint"]}{_configuration["ApiEndpoints:ProductsEndpoint"]} ");

            Console.WriteLine(uri);

            //client.BaseAddress = uri;
            var result = await client.GetFromJsonAsync<List<ProductsDTO>>(uri);
            return result;
        }
    }


}