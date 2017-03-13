using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_4
{
    public class GreetingManager
    {
        //在GreetingManager类的内部声明greetDelegate变量
        public GreetingDelegate greetDelegate;

        public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
    }
}
