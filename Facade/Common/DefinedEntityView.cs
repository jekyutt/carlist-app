using System.ComponentModel;

namespace SemestriProject.Facade.Common
{
    public abstract class DefinedEntityView : NamedEntityView
    {
        [DisplayName("Travel Time")]
        public string TravelTime { get; set; }

        [DisplayName("Order Time")]
        public string OrderTime { get; set; }
    }
}
