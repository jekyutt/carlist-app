using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.AirFreight
{
    public class AmericaRepository : UniqueEntityRepository<America, AmericaData>, IAmericaRepository
    {
        public AmericaRepository(AirFreightDbContext c) : base(c, c.America) { }

        public override America toDomainObjects(AmericaData d) => new America(d);

    }
}
