using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class RepairOrder
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public RepairOrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
