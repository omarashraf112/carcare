using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class EstimateLine : AuditableEntity
    {
        public Guid EstimateId { get; set; }
        public Estimate Estimate { get; set; }

        public string Description { get; set; }
        public EstimateLineType Type { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
