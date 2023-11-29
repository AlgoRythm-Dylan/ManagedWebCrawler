namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexBeginState : State, ITextLexingState
    {
        public LexingScanResult Scan(string character)
        {
            if (character.IsAlpha())
            {
                TransitionState(new UrlLexScanProtocolState());
                return new LexingScanResult()
                {
                    Consumed = false
                };
            }
            else
            {
                return new LexingScanResult();
            }
        }
    }
}
