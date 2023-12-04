/*

URLs in HTML can be either absolute or relative.

They can start off with the protocol, such as https://www.google.com/abc
They can be relative such as "abc" or absolute-relative such as "/abc"
If starting off without the protocol, such as www.google.com/abc,
    it is treated as a relative path


*/
namespace ManagedWebCrawler.Lib.Url.LexingState
{
    public class UrlLexBeginState : State, ITextLexingState
    {
        protected string Memory { get; set; } = "";
        public LexingScanResult Scan(string character)
        {
            //if (character.IsAlpha())
            //{
            //    TransitionState(new UrlLexScanProtocolState());
            //    return new LexingScanResult()
            //    {
            //        Consumed = false
            //    };
            //}
            //else
            //{
            //    return new LexingScanResult();
            //}
            if(character == "/")
            {
                // Character only seen in a path - identifying this as a relative
                // path
            }
            else if(character == ":")
            {
                // End of protocol name - "https://"
            }
            else if(character == " ")
            {
                // Leading whitespaces can be skipped
                if(Memory.Length == 0)
                {

                }
                else
                {
                    // Technically should be encoded as %20
                    // but we'll be forgiving
                    Memory += character;
                }
            }
            else if(character == "")
            {
                // Empty sting means there's nothing left in the buffer
                // Can happen for simpler relative paths such as "home"
            }
        }
    }
}
