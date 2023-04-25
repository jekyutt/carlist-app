using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.RoadFreight
{
    public sealed class Baltic : Entity<BalticData>
    {
        public Baltic() : this(null) { }
        public Baltic(BalticData d) : base(d) { }
    }
}
