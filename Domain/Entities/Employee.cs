using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Employee : TenantScopedEntity
    {
        public Guid UserId { get; set; }
        public Guid? BranchId { get; set; } // nullable = Owner is tenant-wide
        public Branch Branch { get; set; }

        public EmployeeRole EmployeeRole { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
