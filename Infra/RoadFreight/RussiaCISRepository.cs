using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.RoadFreight
{
    public class RussiaCISRepository : UniqueEntityRepository<RussiaAndCIS, RussiaAndCISData>, IRussiaCISRepository
    {
        public RussiaCISRepository(RoadFreightDbContext c) : base(c, c.RussiaAndCIS) { }

        public override RussiaAndCIS toDomainObjects(RussiaAndCISData d) => new RussiaAndCIS(d);

    }
}
