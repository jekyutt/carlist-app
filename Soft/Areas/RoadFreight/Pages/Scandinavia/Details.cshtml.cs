using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Pages.RoadFreight;

namespace SemestriProject.Soft.Areas.RoadFreight.Pages.Scandinavia
{
    public class DetailsModel : ScandinaviasPage
    {
        public DetailsModel(IScandinaviasRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
