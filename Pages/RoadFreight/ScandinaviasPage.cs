using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.RoadFreight
{
    public abstract class ScandinaviasPage : BasePage<IScandinaviasRepository, Scandinavia, ScandinaviaView, ScandinaviaData>
    {
        protected internal ScandinaviasPage(IScandinaviasRepository r) : base(r)
        {
            PageTitle = "Scandinavia";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/RoadFreight/Scandinavia";

        public override Scandinavia toObject(ScandinaviaView view)
        {
            return ScandinaviaViewFactory.Create(view);
        }

        public override ScandinaviaView toView(Scandinavia obj)
        {
            return ScandinaviaViewFactory.Create(obj);
        }
    }
}
