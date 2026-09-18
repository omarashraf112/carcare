using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class MaintenanceCenter
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double RatingAvg { get; set; }

        public ICollection<Branch> Branches { get; set; }
    }
}
