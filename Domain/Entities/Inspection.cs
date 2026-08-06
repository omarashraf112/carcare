using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Inspection : TenantScopedEntity
    {
        public Guid RepairOrderId { get; set; }
        public RepairOrder RepairOrder { get; set; }

        public Guid MechanicId { get; set; }
        public Employee Mechanic { get; set; }

        public string Notes { get; set; }
        public List<string> MediaUrls { get; set; } // JSON list, optional photos/videos
    }
}
