namespace Shared.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }  // Mandatory field
        public decimal Price { get; set; }
    }
}
