using System;

namespace Domain.Entities
{
    // Nullable-FK approach — exactly one of CenterId / ShopId should be set
    public class Review
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public Guid? CenterId { get; set; }
        public MaintenanceCenter Center { get; set; }

        public Guid? ShopId { get; set; }
        public PartsShop Shop { get; set; }

        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
