namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexScanProtocolGrammarState : State, ITextLexingState
    {
        public LexingScanResult Scan(string character)
        {
            if (character == ":" || character == "/")
            {
                return new LexingScanResult()
                {
                    Tokens = new List<Token>() { new PunctuationToken { Value = character } }
                };
            }
            else
            {
                // Transition to domain parse state
                TransitionState(new UrlLexEndState());
                return new LexingScanResult { Consumed = false };
            }
        }
    }
}
