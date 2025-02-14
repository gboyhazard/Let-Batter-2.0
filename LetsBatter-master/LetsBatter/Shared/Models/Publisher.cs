namespace LetsBatter.Shared.Models
{
    public class Publisher
    {
        public int Id { get; set; }  // Unique identifier for the publisher

        public required string Name { get; set; }  // Publisher's name

        public required string ContactEmail { get; set; }  // Publisher's contact email
        
        public required string PhoneNumber { get; set; }  // Contact number

        public required string Address { get; set; }  // Publisher's physical address

        public string? WebsiteUrl { get; set; }  // Publisher's website (optional)

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Timestamp of creation

        public DateTime? UpdatedAt { get; set; }  // Last update timestamp (nullable)

        // Navigation property for products published by this publisher
        public List<Product> Products { get; set; } = new();  
    }
}
