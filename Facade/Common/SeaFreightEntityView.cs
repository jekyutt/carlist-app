using System.ComponentModel;

namespace SemestriProject.Facade.Common
{
    public abstract class SeaFreightEntityView : DefinedEntityView
    {
        [DisplayName("Lifting Capacity")]
        public string LiftingCapacity { get; set; }

        [DisplayName("Container Type")]
        public string ContainerType { get; set; }
    }
}
