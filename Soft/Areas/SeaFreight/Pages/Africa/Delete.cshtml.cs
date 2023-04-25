using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Pages.SeaFreight;

namespace SemestriProject.Soft.Areas.SeaFreight.Pages.Africa
{
    public class DeleteModel : AfricaPage
    {
        public DeleteModel(IAfricaRepository r) : base(r)
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

