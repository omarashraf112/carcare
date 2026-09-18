using Domain.Enums;
using System;

namespace Domain.Entities
{
    // Nullable-FK approach (agreed instead of polymorphic reference)
    public class Complaint
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid? BookingId { get; set; }
        public Booking Booking { get; set; }

        public Guid? OrderId { get; set; }
        public Order Order { get; set; }

        public string Description { get; set; }
        public ComplaintStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
