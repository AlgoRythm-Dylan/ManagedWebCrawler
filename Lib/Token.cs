using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib
{
    public class Token { }
    
    public class EOFToken : Token { }

    public class StringToken : Token
    {
        public string? Value { get; set; }
    }

    public class PunctuationToken : Token
    {
        public string? Value { get; set; }
    }

    public class IntegerToken : Token
    {
        public long Value { get; set; }
    }

    public class DecimalToken : Token
    {
        public double Value { get; set; }
    }

}
