using System;

namespace ParisarUI.Dashboard
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();

        public required string CustomerName { get; set; }

        public required string Country { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public OrderType OrderType { get; set; }

        public decimal GrossValue { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal NetValue => GrossValue * (1 - (DiscountPercentage / 100));
    }

    public enum OrderType
    {
        Web, Contract, Mail, Phone
    }
}