namespace posexample.Models;

public class ProductsDTO
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public decimal? Price { get; set; }

    public Int16? Quantity { get; set; }
}