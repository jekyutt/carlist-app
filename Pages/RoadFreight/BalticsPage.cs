using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.RoadFreight
{
    public abstract class BalticsPage : BasePage<IBalticsRepository, Baltic, BalticView, BalticData>
    {
        protected internal BalticsPage(IBalticsRepository r) : base(r)
        {
            PageTitle = "Baltic";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/RoadFreight/Baltic";

        public override Baltic toObject(BalticView view)
        {
            return BalticViewFactory.Create(view);
        }

        public override BalticView toView(Baltic obj)
        {
            return BalticViewFactory.Create(obj);
        }
    }
}
