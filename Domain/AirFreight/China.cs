using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.AirFreight
{
    public sealed class China : Entity<ChinaData>
    {
        public China() : this(null) { }
        public China(ChinaData d) : base(d) { }
    }
}
