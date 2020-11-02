using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using HelpToHelp.Business.UIDescriptors.TreeIcons;
using HelpToHelp.Models.Pages;


namespace HelpToHelp.Models.Container
{
    [ContentType(
        GUID = "80840C2D-E266-4E3A-B11E-304CD480B574",
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Container : News"
    )]
    [AvailableContentTypes(
        EPiServer.DataAbstraction.Availability.Specific,
        Include = new[] { typeof(NewsPage) })]
    public class NewsContainer : SitePageData, IUseArticleTreeIcon
    {
    }
}