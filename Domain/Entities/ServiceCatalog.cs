using System;

namespace Domain.Entities
{
    public class ServiceCatalog
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public int DurationMinutes { get; set; }
    }
}
