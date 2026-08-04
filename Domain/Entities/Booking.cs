using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Booking : TenantScopedEntity
    {
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public Guid ServiceCatalogId { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }

        public DateTime ScheduledAt { get; set; } // indexed with TenantId + BranchId
        public string Notes { get; set; }
        public BookingStatus Status { get; set; }
    }
}
