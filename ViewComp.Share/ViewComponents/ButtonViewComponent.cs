using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewComp.Share.Models;

namespace ViewComp.Share.ViewComponents
{
    [ViewComponent] // Il nome della classe deve terminare con ViewComponent
    public class ButtonViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string text, string glyphicon, string buttontype)
        {
            // Si può eseguire codice di accesso al db, configurazione o altre logiche business. Come un controller normale
            ButtonViewModel model = new ButtonViewModel
            {
                Glyphicon = string.Concat("glyphicon-", glyphicon),
                ButtonType = buttontype,
                Text = text
            };
            return View(model);
        }
    }
}
