using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Payment : TenantScopedEntity
    {
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public string TransactionRef { get; set; } // optional, e.g. Paymob reference
        public DateTime PaidAt { get; set; }
    }
}
