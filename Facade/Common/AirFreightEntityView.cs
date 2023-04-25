using System.ComponentModel;

namespace SemestriProject.Facade.Common
{
    public abstract class AirFreightEntityView : DefinedEntityView
    {
        [DisplayName("Type Of Cargo")]
        public string TypeOfCargo { get; set; }

        [DisplayName("Airplane Type")]
        public string AirplaneType { get; set; }
    }
}
