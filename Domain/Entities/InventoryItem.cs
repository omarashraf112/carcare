using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class InventoryItem : TenantScopedEntity
    {
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }

        public string SKU { get; set; } // unique per branch
        public string Name { get; set; }
        public int QuantityOnHand { get; set; } // decremented on reserve
        public int ReorderLevel { get; set; }   // triggers low-stock alert
        public decimal UnitCost { get; set; }
    }
}
