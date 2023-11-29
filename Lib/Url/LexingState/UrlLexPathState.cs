namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexPathState : State, ITextLexingState
    {
        public LexingScanResult Scan(string character)
        {
            return new LexingScanResult();
        }
    }
}
