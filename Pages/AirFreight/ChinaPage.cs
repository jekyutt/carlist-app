using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.AirFreight
{
    public abstract class ChinaPage : BasePage<IChinaRepository, China, ChinaView, ChinaData>
    {
        protected internal ChinaPage(IChinaRepository r) : base(r)
        {
            PageTitle = "China";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/AirFreight/China";

        public override China toObject(ChinaView view)
        {
            return ChinaViewFactory.Create(view);
        }

        public override ChinaView toView(China obj)
        {
            return ChinaViewFactory.Create(obj);
        }
    }
}
