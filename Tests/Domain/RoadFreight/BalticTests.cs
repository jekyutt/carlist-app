using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.Common;
using SemestriProject.Domain.RoadFreight;

namespace SemestriProject.Tests.Domain.RoadFreight
{
    [TestClass]
    public class BalticTests : SealedClassTests<Baltic, Entity<BalticData>> { }
}
