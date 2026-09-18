using System;

namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public Guid ShopId { get; set; }
        public PartsShop Shop { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsVerified { get; set; }
    }
}
