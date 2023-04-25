using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Tests.Infra.Common
{
    [TestClass]
    public class UniqueEntityRepositoryTests : AbstractClassTests<UniqueEntityRepository<America, AmericaData>,
        PaginatedRepository<America, AmericaData>>
    {
        private class testClass : PaginatedRepository<America, AmericaData>
        {

            public testClass(DbContext c, DbSet<AmericaData> s) : base(c, s) { }

            public override America toDomainObjects(AmericaData d) => new America(d);

            protected override async Task<AmericaData> getData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }

            protected override string getId(America entity) => entity?.Data?.Id;

        }

    }
}
