using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RepairOrder : TenantScopedEntity
    {
        public Guid BookingId { get; set; } // unique, required
        public Booking Booking { get; set; }

        public Guid? AssignedMechanicId { get; set; } // nullable until assigned
        public Employee AssignedMechanic { get; set; }

        public RepairOrderStatus Status { get; set; }
        public DateTime OpenedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
    }
}
