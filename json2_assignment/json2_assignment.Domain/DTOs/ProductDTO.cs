namespace json2_assignment.Domain.DTOs;

public class ProductDto
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
}