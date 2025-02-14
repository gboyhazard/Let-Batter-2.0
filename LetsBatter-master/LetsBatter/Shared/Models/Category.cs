namespace LetsBatter.Shared.Models
{
    public class Category
    {
        public required int Id { get; set; }  // Unique identifier for the category
        public required string Name { get; set; }  // Name of the category, e.g., "Electronics"
        public string? Description { get; set; }  // A short description of the category (nullable)
        public required DateTime CreatedAt { get; set; }  // Date the category was created
        public DateTime? UpdatedAt { get; set; }  // Date the category was last updated (nullable)

        // Optionally, you can add more properties related to the category (e.g., image URL)
        public string? ImageUrl { get; set; }  // URL of an image representing the category (optional)

        // Optionally, you could also add a method for category-specific logic or validation if needed
    }
}
