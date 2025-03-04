using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public class Feedback
    {
        public int Id { get; set; }

        // Foreign key to Customer
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        // Foreign key to Product
        public int ProductId { get; set; }

        public Product Product { get; set; }

        // Rating between 1 and 5
        public int Rating { get; set; }

        // Optional comment with maximum length
        public string? Comment { get; set; }

        // Timestamp of feedback submission
        public DateTime CreatedAt { get; set; }

        // Timestamp of feedback updation
        public DateTime UpdatedAt { get; set; }
    }
}
