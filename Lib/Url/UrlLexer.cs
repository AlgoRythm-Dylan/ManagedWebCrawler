using ManagedWebCrawler.Lib.Url.LexingState;

namespace ManagedWebCrawler.Lib.Url
{
    public class UrlLexer : Lexer, ITextLexer
    {
        protected Stream Stream { get; set; }
        private StreamReader Reader { get; set; }
        protected ITextLexingState CurrentLexingState
        {
            get
            {
                return (ITextLexingState)CurrentState;
            }
        }
        public UrlLexer(Stream stream)
        {
            Stream = stream;
            Reader = new StreamReader(stream);
            CurrentState = new UrlLexBeginState() { Machine = this };
        }

        public Token Next()
        {
            if(TokenBuffer.Count > 0)
            {
                return TokenBuffer.Dequeue();
            }

            while (true)
            {
                int nextValue = Reader.Peek();
                string nextChar;
                if (nextValue == -1)
                {
                    nextChar = "";
                }
                else
                {
                    nextChar = char.ConvertFromUtf32(nextValue);
                }
                 
                var result = CurrentLexingState.Scan(nextChar);
                if (result.Consumed)
                {
                    Reader.Read();
                }
                if(result.Tokens.Count > 0)
                {
                    for(int i = 1; i < result.Tokens.Count; i++)
                    {
                        TokenBuffer.Enqueue(result.Tokens[i]);
                    }
                    return result.Tokens[0];
                }
            }
        }
    }
}
