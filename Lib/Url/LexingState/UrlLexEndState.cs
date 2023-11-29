namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexEndState : State, ITextLexingState
    {
        public LexingScanResult Scan(string character)
        {
            return new LexingScanResult
            {
                Consumed = false,
                Tokens = new List<Token>() { new EOFToken() }
            };
        }
    }
}
