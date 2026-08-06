using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enums
{
    public enum RepairOrderStatus
    {
        Created,
        Diagnosing,
        AwaitingApproval,
        InProgress,
        Closed
    }
}
