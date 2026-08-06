using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Branch : TenantScopedEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
