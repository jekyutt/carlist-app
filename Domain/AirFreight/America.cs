using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.AirFreight
{
    public sealed class America : Entity<AmericaData>
    {
        public America() : this(null) { }
        public America(AmericaData d) : base(d) { }
    }
}
