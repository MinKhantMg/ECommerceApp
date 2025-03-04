using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Contracts
{
    public class Refund
    {
        public int Id { get; set; }

        // Foreign key to Cancellation
        public int CancellationId { get; set; }

        public Cancellation Cancellation { get; set; }

        // Foreign key to Payment
        public int PaymentId { get; set; }

        public Payment Payment { get; set; }

        // Amount to be refunded
        public decimal Amount { get; set; }

        // Status of the Refund
        public RefundStatus Status { get; set; }

        public string RefundMethod { get; set; }

        public string? RefundReason { get; set; }

        // Transaction ID from the payment gateway
        public string? TransactionId { get; set; }

        // Date and time when the refund was initiated
        public DateTime InitiatedAt { get; set; }

        // Date and time when the refund was completed
        public DateTime? CompletedAt { get; set; }

        //Track who processed (approved) the refund.
        public int? ProcessedBy { get; set; }
    }
}
