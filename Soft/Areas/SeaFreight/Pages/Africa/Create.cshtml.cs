using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Pages.SeaFreight;

namespace SemestriProject.Soft.Areas.SeaFreight.Pages.Africa
{
    public class CreateModel : AfricaPage
    {
        public CreateModel(IAfricaRepository r) : base(r)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
