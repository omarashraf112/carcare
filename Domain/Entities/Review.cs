using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Review : TenantScopedEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid RepairOrderId { get; set; } // unique, required
        public RepairOrder RepairOrder { get; set; }

        public int Rating { get; set; } // 1-5
        public string Comment { get; set; }
    }
}
