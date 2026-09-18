using System;

namespace Domain.Entities
{
    public class Inspection
    {
        public Guid Id { get; set; }

        public Guid RepairOrderId { get; set; }
        public RepairOrder RepairOrder { get; set; }

        public string Findings { get; set; }
        public string Diagnosis { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
