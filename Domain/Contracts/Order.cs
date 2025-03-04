using Domain.Enums;

namespace Domain.Contracts
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        // Foreign key to Customer
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        // Foreign keys to Addresses
        public int BillingAddressId { get; set; }

        public Address BillingAddress { get; set; }

        public int ShippingAddressId { get; set; }

        public Address ShippingAddress { get; set; }

        public decimal TotalBaseAmount { get; set; }

        public decimal TotalDiscountAmount { get; set; }

        public decimal ShippingCost { get; set; }

        public decimal TotalAmount { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public Payment Payment { get; set; } //Linked with Associated Payment

        public Cancellation Cancellation { get; set; } //Linked with Associated Cancellation
    }
}
