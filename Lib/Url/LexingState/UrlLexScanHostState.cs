namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexScanHostState : State, ITextLexingState
    {
        protected string Memory { get; set; } = "";
        public LexingScanResult Scan(string character)
        {
            if(character == "." || character == ":")
            {
                var result = new LexingScanResult();
                if (!string.IsNullOrEmpty(Memory))
                {
                    result.Tokens.Add(new StringToken { Value = Memory });
                    Memory = "";
                }
                result.Tokens.Add(new PunctuationToken { Value = character });
                if(character == ":")
                {
                    TransitionState(new UrlLexScanPortState());
                }
                return result;
            }
            else
            {
                Memory += character;
            }
            return new LexingScanResult();
        }
    }
}
