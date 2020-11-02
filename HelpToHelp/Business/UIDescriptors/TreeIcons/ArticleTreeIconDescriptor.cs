using EPiServer.Shell;
using HelpToHelp.EpiServerDefaultIcon;

namespace HelpToHelp.Business.UIDescriptors.TreeIcons
{
    [UIDescriptorRegistration]
    public class ArticleTreeIconDescriptor : UIDescriptor<IUseArticleTreeIcon>
    {
        public ArticleTreeIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.Category;
        }
    }
    public interface IUseArticleTreeIcon
    {
    }
}