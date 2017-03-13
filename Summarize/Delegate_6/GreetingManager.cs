using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_6
{
    public class GreetingManager
    {
        public event GreetingDelegate greetDelegate;

        public void GreetPeople(string name)
        {
            greetDelegate(name);
        }
    }
}
