using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.AirFreight
{
    public class AustraliaRepository : UniqueEntityRepository<Australia, AustraliaData>, IAustraliaRepository
    {
        public AustraliaRepository(AirFreightDbContext c) : base(c, c.Australia) { }

        public override Australia toDomainObjects(AustraliaData d) => new Australia(d);

    }
}
