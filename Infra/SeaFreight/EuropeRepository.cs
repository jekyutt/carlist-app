using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.SeaFreight
{
    public class EuropeRepository : UniqueEntityRepository<Europe, EuropeData>, IEuropeRepository
    {
        public EuropeRepository(SeaFreightDbContext c) : base(c, c.Europe) { }

        public override Europe toDomainObjects(EuropeData d) => new Europe(d);

    }
}
