using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using posexample.Models;
using posexample.Repository;

namespace posexample.Pages;

public class ProductsModel : PageModel
{

    public IList<ProductsDTO> ProductList { get; set; }

    private readonly ILogger<PrivacyModel> _logger;
    private readonly IProductsRepository _productRepository;

    public ProductsModel(ILogger<PrivacyModel> logger, IProductsRepository productsRepository)
    {
        _logger = logger;
        _productRepository = productsRepository;
    }

    public async Task OnGetAsync()
    {
        ProductList = await _productRepository.GetProducts();
    }
}
