using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_5
{
    public class GreetingManager
    {
        //在GreetingManager类的内部声明greetDelegate变量
        public GreetingDelegate greetDelegate;

        public void GreetPeople(string name)
        {
            if (greetDelegate != null)
            {     //如果有方法注册委托变量
                greetDelegate(name);//通过委托调用方法
            }
        }
    }
}
