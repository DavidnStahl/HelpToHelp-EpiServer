using EPiServer.Core;
using HelpToHelp.Models.ViewModels.Interface;

namespace HelpToHelp.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}