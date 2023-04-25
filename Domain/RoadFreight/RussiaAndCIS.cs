using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.RoadFreight
{
    public sealed class RussiaAndCIS : Entity<RussiaAndCISData>
    {
        public RussiaAndCIS() : this(null) { }

        public RussiaAndCIS(RussiaAndCISData data) : base(data) { }
    }
}