using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib.Url
{
    public class Url
    {
        public Url(string url)
        {
            MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(url));
            UrlLexer lexer = new UrlLexer(stream);
            while(true)
            {
                var result = lexer.Next();
                if(result.GetType() == typeof(EOFToken))
                {
                    break;
                }
            }
            stream.Close();
        }
    }
}
