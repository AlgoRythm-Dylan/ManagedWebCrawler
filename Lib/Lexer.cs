using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib
{
    public class Lexer : StateMachine
    {
        protected Queue<Token> TokenBuffer { get; set; } = new Queue<Token>();
    }

    public class LexingScanResult
    {
        public bool Consumed { get; set; } = true;
        public List<Token> Tokens { get; set; } = new List<Token>();
    }

    public interface ITextLexer
    {
        abstract Token Next();
    }
}
