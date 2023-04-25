using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.Order;
using SemestriProject.Pages.Order;

namespace SemestriProject.Soft.Areas.Order.Pages.MakeOrder
{
    public class DetailsModel : MakeOrderPage
    {
        public DetailsModel(IMakeOrderRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
