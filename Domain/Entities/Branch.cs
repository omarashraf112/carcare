using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Branch
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid CenterId { get; set; }
        public MaintenanceCenter Center { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ICollection<ServiceCatalog> Services { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
