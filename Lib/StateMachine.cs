using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// https://www.freecodecamp.org/news/state-machines-basics-of-computer-science-d42855debc66/
namespace ManagedWebCrawler.Lib
{
    public class StateMachine
    {
        public State? CurrentState { get; set; }
    }
}
