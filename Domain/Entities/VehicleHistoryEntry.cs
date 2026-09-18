using System;

namespace Domain.Entities
{
    public class VehicleHistoryEntry
    {
        public Guid Id { get; set; }

        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public string CenterName { get; set; }
        public string Description { get; set; }
        public DateTime ServiceDate { get; set; }
    }
}
