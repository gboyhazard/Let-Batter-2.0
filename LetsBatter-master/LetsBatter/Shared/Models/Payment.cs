namespace LetsBatter.Shared.Models
{
    public class Payment
    {
        public int Id { get; set; }  // Unique identifier for the payment
        
        public required int UserId { get; set; }  // User associated with the payment
        public required decimal Amount { get; set; }  // Total amount of the payment
        public required DateTime PaymentDate { get; set; }  // Date when the payment was made
        
        public required string PaymentMethod { get; set; }  // Payment method, e.g., Credit Card, PayPal, etc.
        public required string PaymentStatus { get; set; }  // Status of the payment, e.g., Pending, Completed, Failed
        
        public required string TransactionId { get; set; }  // Unique transaction identifier (for tracking)
        public string? PaymentDetails { get; set; }  // Additional payment details, e.g., billing address, transaction notes
        
        public DateTime? RefundDate { get; set; }  // If refunded, the date when the refund occurred
        public decimal? RefundAmount { get; set; }  // Amount refunded, if any
        public bool IsRecurring { get; set; }  // Whether the payment is part of a subscription or recurring payment

        // Method to check if the payment is successful
        public bool IsPaymentSuccessful()
        {
            return PaymentStatus == "Completed" && Amount > 0;
        }

        // Method to check if the payment is eligible for refund
        public bool IsRefundEligible()
        {
            return PaymentStatus == "Completed" && RefundDate == null;
        }
    }
}
