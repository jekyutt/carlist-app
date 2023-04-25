using SemestriProject.Aids.Methods;
using SemestriProject.Domain.Order;

namespace SemestriProject.Facade.Order
{
    public static class MakeOrderViewFactory
    {
        public static MakeOrder Create(MakeOrderView v)
        {
            var o = new MakeOrder();
            Copy.Members(v, o.Data);

            return o;
        }
        public static MakeOrderView Create(MakeOrder o)
        {
            var v = new MakeOrderView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
