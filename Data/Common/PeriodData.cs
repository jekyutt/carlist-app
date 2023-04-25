using System;

namespace SemestriProject.Data.Common
{
    public abstract class PeriodData
    {
        public DateTime? ReadyForCollection { get; set; }
        public DateTime? RequestedDeliveryTime { get; set; }

    }
}