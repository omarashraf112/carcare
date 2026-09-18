using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Estimate
    {
        public Guid Id { get; set; }

        public Guid RepairOrderId { get; set; }
        public RepairOrder RepairOrder { get; set; }

        public string PartName { get; set; }
        public decimal Price { get; set; }
        public EstimateStatus Status { get; set; }
    }
}
