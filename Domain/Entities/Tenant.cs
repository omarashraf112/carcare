using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Tenant : AuditableEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Branch> Branches { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
