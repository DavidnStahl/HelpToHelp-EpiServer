using EPiServer.Shell;
using HelpToHelp.Models.Pages;

namespace HelpToHelp.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<HelpToHelpStartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}