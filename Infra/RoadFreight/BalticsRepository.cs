using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.RoadFreight
{
    public class BalticsRepository : UniqueEntityRepository<Baltic, BalticData>, IBalticsRepository
    {
        public BalticsRepository(RoadFreightDbContext c) : base(c, c.Baltics) { }

        public override Baltic toDomainObjects(BalticData d) => new Baltic(d);

    }
}
