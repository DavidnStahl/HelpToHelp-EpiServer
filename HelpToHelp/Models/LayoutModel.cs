using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpToHelp.Models
{
    public class LayoutModel
    {
        public IEnumerable<PageData> Menu { get; set; }
    }
}