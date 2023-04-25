using System.Threading.Tasks;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Pages.AirFreight;

namespace SemestriProject.Soft.Areas.AirFreight.Pages.Australia
{
    public class IndexModel : AustraliaPage
    {
        public IndexModel(IAustraliaRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

