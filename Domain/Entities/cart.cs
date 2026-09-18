using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public User Customer { get; set; }

        public ICollection<CartItem> Items { get; set; }
    }
}
