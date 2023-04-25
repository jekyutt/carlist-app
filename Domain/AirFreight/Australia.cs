using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.AirFreight
{
    public sealed class Australia : Entity<AustraliaData>
    {
        public Australia() : this(null) { }
        public Australia(AustraliaData d) : base(d) { }
    }
}
