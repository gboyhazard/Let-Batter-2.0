namespace LetsBatter.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public required string Name { get; set; }  // Required Name
        public required string Email { get; set; }  // Required Email
        public required string Password { get; set; }  // Required Password
        public required string Address { get; set; }  // Required Address
        
        // Nullable properties, because they may be optional
        public string? PhoneNumber { get; set; }  // Nullable phone number
        public string? Role { get; set; }  // Nullable role
        public string? ProfilePictureUrl { get; set; }  // Nullable profile picture URL
        
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Constructor ensuring initialization of required properties
        public User(string name, string email, string password, string address, string? phoneNumber = null, string? role = null, string? profilePictureUrl = null)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            PhoneNumber = phoneNumber;
            Role = role;
            ProfilePictureUrl = profilePictureUrl;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        // Method to check if the user is of a valid age (e.g., 18+ years)
        public bool IsOfLegalAge()
        {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateOfBirth > DateTime.Now.AddYears(-age)) age--;
            return age >= 18;
        }
    }
}
