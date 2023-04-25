using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Facade.Order;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.Order
{
    public abstract class MakeOrderPage : BasePage<IMakeOrderRepository, MakeOrder, MakeOrderView, MakeOrderData>
    {
        protected internal MakeOrderPage(IMakeOrderRepository r) : base(r)
        {
            PageTitle = "MakeOrder";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        public override string getPageUrl() => "/Order/MakeOrder";

        public override MakeOrder toObject(MakeOrderView view)
        {
            return MakeOrderViewFactory.Create(view);
        }

        public override MakeOrderView toView(MakeOrder obj)
        {
            return MakeOrderViewFactory.Create(obj);
        }
    }
}
