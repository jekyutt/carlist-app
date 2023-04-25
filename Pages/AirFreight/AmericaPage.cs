using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.AirFreight
{
    public abstract class AmericaPage : BasePage<IAmericaRepository, America, AmericaView, AmericaData>
    {
        protected internal AmericaPage(IAmericaRepository r) : base(r)
        {
            PageTitle = "America";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/AirFreight/America";

        public override America toObject(AmericaView view)
        {
            return AmericaViewFactory.Create(view);
        }

        public override AmericaView toView(America obj)
        {
            return AmericaViewFactory.Create(obj);
        }
    }
}
