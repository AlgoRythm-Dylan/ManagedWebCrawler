using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWebCrawler.Lib
{
    public class State
    {
        public StateMachine? Machine { get; set; }
        public void TransitionState(State newState)
        {
            if(Machine is not null)
            {
                Machine.CurrentState = newState;
                newState.Machine = Machine;
            }
        }
    }

    public class ErrorState : State
    {
        public string Message { get; set; } = "Unknown error";
    }

    public interface ITextLexingState
    {
        public abstract LexingScanResult Scan(string character);
    }
}
