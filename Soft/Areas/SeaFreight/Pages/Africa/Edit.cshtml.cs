using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Pages.SeaFreight;

namespace SemestriProject.Soft.Areas.SeaFreight.Pages.Africa
{
    public class EditModel : AfricaPage
    {
        public EditModel(IAfricaRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }

}
