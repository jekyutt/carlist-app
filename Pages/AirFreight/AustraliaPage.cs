using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.AirFreight
{
    public abstract class AustraliaPage : BasePage<IAustraliaRepository, Australia, AustraliaView, AustraliaData>
    {
        protected internal AustraliaPage(IAustraliaRepository r) : base(r)
        {
            PageTitle = "Australia";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string getPageUrl() => "/AirFreight/Australia";

        public override Australia toObject(AustraliaView view)
        {
            return AustraliaViewFactory.Create(view);
        }

        public override AustraliaView toView(Australia obj)
        {
            return AustraliaViewFactory.Create(obj);
        }
    }
}
