using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Find.Cms;
using System.ComponentModel.DataAnnotations;


namespace HelpToHelp.Models.Blocks
{
    [IndexInContentAreas]
    [ContentType(
        GUID = "DCED6288-9601-471C-8193-330323489907"
    )]

    public class NewsBlock : SiteBlockData
    {
        public virtual bool IndexInContentAreas { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1
        )]
        [CultureSpecific]

        public virtual PageReference NewsContainer { get; set; }
    }
}