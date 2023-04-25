using System.Threading.Tasks;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Pages.RoadFreight;

namespace SemestriProject.Soft.Areas.RoadFreight.Pages.Baltic
{
    public class IndexModel : BalticsPage
    {
        public IndexModel(IBalticsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

