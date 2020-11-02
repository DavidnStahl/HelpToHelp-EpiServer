using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;


namespace HelpToHelp.Models.Pages
{
    [ContentType(
        GUID = "07D87CEC-7659-4CBB-BE79-57E3072C6520",
        DisplayName = "Page : News"
    )]
    public class NewsPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [CultureSpecific]
        [Searchable]

        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [CultureSpecific]
        [Searchable]

        public virtual XhtmlString Text { get; set; }
    }
}