using System.Threading.Tasks;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Pages.SeaFreight;

namespace SemestriProject.Soft.Areas.SeaFreight.Pages.Europe
{
    public class IndexModel : EuropePage
    {
        public IndexModel(IEuropeRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

