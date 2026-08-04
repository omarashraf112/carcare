using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Customer : AuditableEntity,identity
    {
        public Guid UserId { get; set; } // FK -> User (Identity), unique, required
        public string Address { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
