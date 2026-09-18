using System;

namespace Domain.Entities
{
    public class PartsShop
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double RatingAvg { get; set; }
    }
}
