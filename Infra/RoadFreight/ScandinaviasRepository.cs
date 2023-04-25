using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.RoadFreight
{
    public class ScandinaviasRepository : UniqueEntityRepository<Scandinavia, ScandinaviaData>, IScandinaviasRepository
    {
        public ScandinaviasRepository(RoadFreightDbContext c) : base(c, c.Scandinavia) { }

        public override Scandinavia toDomainObjects(ScandinaviaData d) => new Scandinavia(d);

    }
}
