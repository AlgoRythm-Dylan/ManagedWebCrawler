namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexScanProtocolState : State, ITextLexingState
    {
        protected string Memory { get; set; } = "";
        public LexingScanResult Scan(string character)
        {
            if (character.IsAlpha())
            {
                Memory += character;
                return new LexingScanResult();
            }
            else
            {
                if (character == ":")
                {
                    TransitionState(new UrlLexScanProtocolGrammarState());
                    return new LexingScanResult()
                    {
                        Consumed = false,
                        Tokens = new List<Token>() { new StringToken { Value = Memory } }
                    };
                }
                else
                {
                    TransitionState(new ErrorState() { Message = $"Malformed URL: illegal character \"{character}\"" });
                    return new LexingScanResult();
                }
            }
        }
    }
}
