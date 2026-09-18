using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public PaymentStatus Status { get; set; }
        public string PaymobTxnId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
