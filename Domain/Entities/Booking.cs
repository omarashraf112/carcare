using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public Guid ServiceCatalogId { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }

        public DateTime ScheduledAt { get; set; } // indexed with TenantId + BranchId
        public string Notes { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
