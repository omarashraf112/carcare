using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Invoice : TenantScopedEntity
    {
        public Guid RepairOrderId { get; set; } // unique, required
        public RepairOrder RepairOrder { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateTime IssuedAt { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
