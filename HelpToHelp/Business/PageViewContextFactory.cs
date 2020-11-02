using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using HelpToHelp.Models;
using HelpToHelp.Models.Pages;
using System.Linq;
using System.Web.Routing;

namespace HelpToHelp.Business
{
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;

        public PageViewContextFactory(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }

            var startPage = _contentLoader.Get<HelpToHelpStartPage>(startPageContentLink);
            var menu = _contentLoader.GetChildren<PageData>(startPage.ContentLink).Where(x => x.VisibleInMenu).ToList();
            menu.Insert(0, startPage);
            return new LayoutModel
            {
                Menu = menu
            };
        }
    }
}