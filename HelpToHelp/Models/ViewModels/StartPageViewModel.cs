using EPiServer;
using EPiServer.Core;
using HelpToHelp.Models.Pages;
using System.Collections.Generic;


namespace HelpToHelp.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<HelpToHelpStartPage>
    {
        public IEnumerable<PageData> Menu { get; set; }
        public StartPageViewModel(HelpToHelpStartPage currentPage) : base(currentPage)
        {
            var contentLoader = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentLoader>();
            Menu = contentLoader.GetChildren<PageData>(currentPage.ContentLink);
        }
    }
}