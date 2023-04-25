using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Facade.SeaFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.SeaFreight
{
    public abstract class AfricaPage : BasePage<IAfricaRepository, Africa, AfricaView, AfricaData>
    {
        protected internal AfricaPage(IAfricaRepository r) : base(r)
        {
            PageTitle = "Africa";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/SeaFreight/Africa";

        public override Africa toObject(AfricaView view)
        {
            return AfricaViewFactory.Create(view);
        }

        public override AfricaView toView(Africa obj)
        {
            return AfricaViewFactory.Create(obj);
        }
    }
}
