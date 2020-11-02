using EPiServer.Core;

namespace HelpToHelp.Models.Blocks
{
    public class ShouldIndexInContentAreaConvention : EPiServer.Find.Cms.Conventions.IShouldIndexInContentAreaConvention
    {
        public bool? ShouldIndexInContentArea(IContent content)
        {
            return content is NewsBlock;
        }
    }
}