using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.Order;
using SemestriProject.Pages.Order;

namespace SemestriProject.Soft.Areas.Order.Pages.MakeOrder
{
    public class DeleteModel : MakeOrderPage
    {
        public DeleteModel(IMakeOrderRepository r) : base(r)
        {
        }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }

}

