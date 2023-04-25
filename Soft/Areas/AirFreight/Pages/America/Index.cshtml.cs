using System.Threading.Tasks;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Pages.AirFreight;

namespace SemestriProject.Soft.Areas.AirFreight.Pages.America
{
    public class IndexModel : AmericaPage
    {
        public IndexModel(IAmericaRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

