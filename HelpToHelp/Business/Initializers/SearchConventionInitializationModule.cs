using EPiServer.Core;
using EPiServer.Find.ClientConventions;
using EPiServer.Find.Cms;
using EPiServer.Find.Cms.Json;
using EPiServer.Find.Framework;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using HelpToHelp.Models.Blocks;

namespace HelpToHelp.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Find.Cms.Module.IndexingModule))]
    public class SearchConventionInitializationModule : IInitializableModule
    {
        private const int MaxDepth = 4;

        public void Initialize(InitializationEngine context)
        {
            ContentIndexer.Instance.Conventions.ShouldIndexInContentAreaConvention = new ShouldIndexInContentAreaConvention();
            SearchClient.Instance.Conventions.ForInstancesOf<ContentArea>().ModifyContract(x => x.Converter = new MaxDepthContentAreaConverter(MaxDepth));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}