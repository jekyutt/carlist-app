using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.SeaFreight
{
    public sealed class Europe : Entity<EuropeData>
    {
        public Europe() : this(null) { }
        public Europe(EuropeData d) : base(d) { }
    }
}
