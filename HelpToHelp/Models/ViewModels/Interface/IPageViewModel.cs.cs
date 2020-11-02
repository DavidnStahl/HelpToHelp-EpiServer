using EPiServer.Core;

namespace HelpToHelp.Models.ViewModels.Interface
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }
}
