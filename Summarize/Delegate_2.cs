using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize
{
    class Delegate_2
    {
        //使用委托可以将多个方法绑定到同一个委托变量，
        //当调用此变量时(这里用“调用”这个词，是因为此变量代表一个方法)，可以依次调用所有绑定的方法。
        //static void Main(string[] args)
        //{
        //    //方法一：
        //    //GreetingDelegate greetDelegate;
        //    //greetDelegate = EnglishGreeting;
        //    //greetDelegate += ChineseGreeting;
        //    //方法二：
        //    GreetingDelegate greetDelegate = new GreetingDelegate(EnglishGreeting);
        //    greetDelegate += ChineseGreeting;
        //    GreetPeople("Tom", greetDelegate);
        //    //取消委托的方法绑定
        //    greetDelegate -= ChineseGreeting;

        //    GreetPeople("Tom", greetDelegate);
        //    Console.Read();
        //}

        private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }

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
