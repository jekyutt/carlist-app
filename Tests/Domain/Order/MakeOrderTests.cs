using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Order;
using SemestriProject.Domain.Common;
using SemestriProject.Domain.Order;

namespace SemestriProject.Tests.Domain.Order
{
    [TestClass]
    public class MakeOrderTests : SealedClassTests<MakeOrder, Entity<MakeOrderData>> { }
}
