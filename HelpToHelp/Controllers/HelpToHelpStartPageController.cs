using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using HelpToHelp.Models.Pages;
using HelpToHelp.Models.ViewModels;

namespace HelpToHelp.Controllers
{
    public class HelpToHelpStartPageController : PageControllerBase<HelpToHelpStartPage>
    {
        public ActionResult Index(HelpToHelpStartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}