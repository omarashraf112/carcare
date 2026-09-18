using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class TowRequest
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public Guid? BranchId { get; set; }
        public Branch Branch { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TowStatus Status { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
