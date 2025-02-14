namespace LetsBatter.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }  // Unique identifier for the product
        
        public required string Name { get; set; }  // Product name (required)
        
        public required string Description { get; set; }  // Product description (required)
        
        public required decimal Price { get; set; }  // Product price (required)
        
        public int CategoryId { get; set; }  // Foreign key to Category
        
        public required string ImageUrl { get; set; }  // Image URL (required)
        
        public int StockQuantity { get; set; }  // Available stock quantity
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Creation timestamp
        
        public DateTime? UpdatedAt { get; set; }  // Last update timestamp (nullable)
        
        // Navigation property for Category
        public Category? Category { get; set; }
    }
}
