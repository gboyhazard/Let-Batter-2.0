using LetsBatter.Shared.Models;

public class Order
{
    public required int Id { get; set; }  // Unique identifier for the order
    public required int UserId { get; set; }  // User who placed the order
    public required List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();  // List of items in the order, initialized as an empty list
    public required decimal TotalAmount { get; set; }  // Total amount of the order
    public required DateTime OrderDate { get; set; }  // Date when the order was placed
    public required string OrderStatus { get; set; }  // Status of the order, e.g., "Pending", "Shipped", "Delivered"
    public required string PaymentStatus { get; set; }  // Payment status, e.g., "Pending", "Paid", "Failed"
    public required string ShippingAddress { get; set; }  // Shipping address for the order
    public DateTime? ShippingDate { get; set; }  // Date when the order was shipped
    public DateTime? EstimatedDeliveryDate { get; set; }  // Estimated delivery date of the order
    public required string TrackingNumber { get; set; }  // Shipping tracking number for the order
    public required string ShippingMethod { get; set; }  // Shipping method chosen for the order
    public required string OrderNotes { get; set; }  // Any special instructions or notes for the order

    // Method to calculate the total price of the order based on items
    public void CalculateTotalAmount()
    {
        TotalAmount = OrderItems.Sum(item => item.Quantity * item.Price);
    }

    // Method to check if the order has been shipped
    public bool IsShipped()
    {
        return OrderStatus == "Shipped" && ShippingDate.HasValue;
    }

    // Method to check if the order is completed (paid and delivered)
    public bool IsCompleted()
    {
        return OrderStatus == "Delivered" && PaymentStatus == "Paid";
    }
}
