using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewComp.Share.Models;

namespace ViewComp.Share.ViewComponents
{
    [ViewComponent] // Il nome della classe deve terminare con ViewComponent
    public class TitleViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string header, string subtext)
        {
            TitleViewModel model = new TitleViewModel
            {
                Header = header,
                SubText = subtext
            };
            return View(model);
        }
    }
}
