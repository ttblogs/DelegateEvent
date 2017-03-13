using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_5
{
    class Delegate_5
    {
        //事件由来3
        //static void Main(string[] args)
        //{
        //    GreetingManager gm = new GreetingManager();
        //    gm.greetDelegate = EnglishGreeting;
        //    gm.greetDelegate += ChineseGreeting;

        //    gm.GreetPeople("Tom");//注意，这次不需要再传递greetDelegate变量
        //    Console.Read();
        //}

        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Moring：" + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好：" + name);
        }
    }
}
