using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_4
{
    class Delegate_4
    {
        //事件由来2
        //static void Main(string[] args)
        //{
        //    GreetingManager gm = new GreetingManager();
        //    gm.greetDelegate = EnglishGreeting;
        //    gm.greetDelegate += ChineseGreeting;

        //    gm.GreetPeople("Tom", gm.greetDelegate);
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
