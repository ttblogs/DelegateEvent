using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_3
{
    class Delegate_3
    {
        //事件由来1
        //static void Main(string[] args)
        //{
        //    GreetingManager gm = new GreetingManager();
        //    gm.GreetPeople("Jimmy Zhang", EnglishGreeting);
        //    gm.GreetPeople("张子阳", ChineseGreeting);
        //    GreetingDelegate greetDelegate = new GreetingDelegate(EnglishGreeting);
        //    greetDelegate += ChineseGreeting;
        //    gm.GreetPeople("Tom", greetDelegate);
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
