using Domain.Enums;


namespace Domain.Contracts
{
    public class Cancellation
    {
        public int Id { get; set; }

        // Foreign key to Order
        public int OrderId { get; set; }

        public Order Order { get; set; }

        // Reason for cancellation
        public string Reason { get; set; }

        // Status of the cancellation request
        public CancellationStatus Status { get; set; }

        // Date and time when the cancellation was requested
        public DateTime RequestedAt { get; set; }

        // Date and time when the cancellation was processed
        public DateTime? ProcessedAt { get; set; }

        // ID of the admin or system that processed the cancellation
        public int? ProcessedBy { get; set; } // Could link to an Admin entity if available

        // The order amount at the time of cancellation request initiation.
        public decimal OrderAmount { get; set; }

        // The cancellation charges applied (if any).
        public decimal? CancellationCharges { get; set; } = 0.00m;

        public string? Remarks { get; set; }

        //Reference Navigation Property
        public Refund Refund { get; set; }
    }
}
