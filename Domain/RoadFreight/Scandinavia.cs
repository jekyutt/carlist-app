using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.RoadFreight
{
    public sealed class Scandinavia : Entity<ScandinaviaData>
    {
        public Scandinavia() : this(null) { }

        public Scandinavia(ScandinaviaData data) : base(data) { }
    }
}
