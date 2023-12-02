using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib.HTML
{
    public class Element
    {
        public string TagName { get; set; } = "";
        public Dictionary<string, string> Attributes { get; set; } = new();
        public List<Element> Children { get; set; } = new();
        public string Content = "";
    }
}
