using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SemestriProject.Facade.Common
{
    public abstract class PeriodView
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Ready For Collection")]
        public DateTime? ReadyForCollection { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Requested Delivery Time")]
        public DateTime? RequestedDeliveryTime { get; set; }
    }
}