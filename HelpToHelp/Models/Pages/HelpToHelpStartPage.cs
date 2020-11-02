using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace HelpToHelp.Models.Pages
{
    [ContentType(
        GUID = "CFA2455F-2CB5-4DE5-80F4-70E898CC2AAC",
        DisplayName = "Start Page"
    )]


    public class HelpToHelpStartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [CultureSpecific]

        public virtual ContentArea ContentArea { get; set; }
    }
}