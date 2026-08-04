using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Vehicle : AuditableEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; } // unique, indexed
        public string VIN { get; set; }         // optional, unique
        public int Mileage { get; set; }
        public string Color { get; set; }
    }
}
