using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.SeaFreight
{
    public sealed class Africa : Entity<AfricaData>
    {
        public Africa() : this(null) { }
        public Africa(AfricaData d) : base(d) { }
    }
}
