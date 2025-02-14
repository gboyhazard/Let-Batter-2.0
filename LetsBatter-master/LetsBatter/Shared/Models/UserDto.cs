namespace LetsBatter.Shared.Models
{
    public class UserDto
    {
        public int Id { get; set; }  // Unique identifier for the user
        
        public required string Username { get; set; }  // Required username
        
        public required string Email { get; set; }  // Required email
        
        public required string FullName { get; set; }  // Required full name
        
        public required string Role { get; set; }  // User role (e.g., Admin, Buyer, Seller)
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Account creation timestamp
    }
}
