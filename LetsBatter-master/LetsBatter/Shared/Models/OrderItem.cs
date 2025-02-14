namespace LetsBatter.Shared.Models
{
    public class OrderItem
    {
        public int Id { get; set; }  // Unique identifier for the order item
        public int OrderId { get; set; }  // The order this item belongs to
        public int ProductId { get; set; }  // The ID of the product being ordered
        public required string ProductName { get; set; }  // Required Product Name
        public required decimal Price { get; set; }  // Required Price
        public required int Quantity { get; set; }  // Required Quantity
        public decimal SubTotal => Price * Quantity;  // Subtotal for this particular item

        // Optional: Additional properties for the item
        public string? ProductDescription { get; set; }  // Optional description of the product
        public string? Category { get; set; }  // Optional category or type of the product (e.g., electronics, clothing)

        // Method to calculate the total price for this item
        public decimal CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        // Optional: Method to update the quantity of the item
        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        // Optional: Method to check if the item is in stock (this could be integrated with the product inventory)
        public bool IsInStock(int availableStock)
        {
            return Quantity <= availableStock;
        }
    }
}
