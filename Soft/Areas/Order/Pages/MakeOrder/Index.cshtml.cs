using System.Threading.Tasks;
using SemestriProject.Domain.Order;
using SemestriProject.Pages.Order;

namespace SemestriProject.Soft.Areas.Order.Pages.MakeOrder
{
    public class IndexModel : MakeOrderPage
    {
        public IndexModel(IMakeOrderRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

