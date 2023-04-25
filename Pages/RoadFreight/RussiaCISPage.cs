using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.RoadFreight
{
    public abstract class RussiaCISPage : BasePage<IRussiaCISRepository, RussiaAndCIS, RussiaAndCISView, RussiaAndCISData>
    {
        protected internal RussiaCISPage(IRussiaCISRepository r) : base(r)
        {
            PageTitle = "Russia And CIS";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/RoadFreight/RussiaAndCIS";

        public override RussiaAndCIS toObject(RussiaAndCISView view)
        {
            return RussiaAndCISViewFactory.Create(view);
        }

        public override RussiaAndCISView toView(RussiaAndCIS obj)
        {
            return RussiaAndCISViewFactory.Create(obj);
        }
    }
}
