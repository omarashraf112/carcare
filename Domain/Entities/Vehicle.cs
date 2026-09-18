using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public string PlateNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public ICollection<VehicleHistoryEntry> History { get; set; }
    }
}
