using SemestriProject.Data.Order;
using SemestriProject.Domain.Common;

namespace SemestriProject.Domain.Order
{
    public sealed class MakeOrder : Entity<MakeOrderData>
    {
        public MakeOrder() : this(null) { }
        public MakeOrder(MakeOrderData d) : base(d) { }
    }
}
