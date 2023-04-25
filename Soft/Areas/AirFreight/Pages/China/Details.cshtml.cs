using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Pages.AirFreight;

namespace SemestriProject.Soft.Areas.AirFreight.Pages.China
{
    public class DetailsModel : ChinaPage
    {
        public DetailsModel(IChinaRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
