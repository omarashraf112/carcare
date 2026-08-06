using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class TenantScopedEntity : AuditableEntity
    {
        public Guid TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
