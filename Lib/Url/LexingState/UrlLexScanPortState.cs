using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexScanPortState : State, ITextLexingState
    {
        public LexingScanResult Scan(string character)
        {
            return new LexingScanResult();
        }
    }
}
