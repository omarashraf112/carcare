using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public OrderStatus Status { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<OrderItem> Items { get; set; }
        public Payment Payment { get; set; }
    }
}
