using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Pages.RoadFreight;

namespace SemestriProject.Soft.Areas.RoadFreight.Pages.Baltic
{
    public class DeleteModel : BalticsPage
    {
        public DeleteModel(IBalticsRepository r) : base(r)
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

