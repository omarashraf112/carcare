using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ServiceCatalog : TenantScopedEntity
    {
        public Guid? BranchId { get; set; } // nullable = available at all branches
        public Branch Branch { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public int EstimatedDurationMinutes { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
