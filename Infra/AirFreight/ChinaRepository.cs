using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.AirFreight
{
    public class ChinaRepository : UniqueEntityRepository<China, ChinaData>, IChinaRepository
    {
        public ChinaRepository(AirFreightDbContext c) : base(c, c.China) { }

        public override China toDomainObjects(ChinaData d) => new China(d);

    }
}
