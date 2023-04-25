using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Infra.Common;

namespace SemestriProject.Infra.Order
{
    public class MakeOrderRepository : UniqueEntityRepository<MakeOrder, MakeOrderData>, IMakeOrderRepository
    {
        public MakeOrderRepository(OrderDbContext c) : base(c, c.MakeOrder) { }

        public override MakeOrder toDomainObjects(MakeOrderData d) => new MakeOrder(d);

    }
}
