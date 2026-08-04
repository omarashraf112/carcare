using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Estimate : TenantScopedEntity
    {
        public Guid RepairOrderId { get; set; } // unique, required
        public RepairOrder RepairOrder { get; set; }

        public decimal TotalAmount { get; set; } // sum of lines
        public DateTime ExpiresAt { get; set; }
        public DateTime? ApprovedAt { get; set; } // mutually exclusive with RejectedAt
        public DateTime? RejectedAt { get; set; }

        public ICollection<EstimateLine> Lines { get; set; }
    }
}
