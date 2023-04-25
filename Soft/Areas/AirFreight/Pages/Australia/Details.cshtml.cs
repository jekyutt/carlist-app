using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Pages.AirFreight;

namespace SemestriProject.Soft.Areas.AirFreight.Pages.Australia
{
    public class DetailsModel : AustraliaPage
    {
        public DetailsModel(IAustraliaRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
