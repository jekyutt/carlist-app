using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.Order;

namespace SemestriProject.Tests.Infra.Order
{
    [TestClass]
    public class MakeOrderRepositoryTests : RepositoryTests<MakeOrderRepository, MakeOrder, MakeOrderData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<OrderDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new OrderDbContext(options);
            dbSet = ((OrderDbContext)db).MakeOrder;
            obj = new MakeOrderRepository((OrderDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<MakeOrder, MakeOrderData>);

        protected override string getId(MakeOrderData d) => d.Id;

        protected override MakeOrder getObject(MakeOrderData d) => new MakeOrder(d);

        protected override void setId(MakeOrderData d, string id) => d.Id = id;
    }
}
