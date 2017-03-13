using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//参考自：http://www.tracefact.net/CSharp-Programming/Delegates-and-Events-in-CSharp.aspx
namespace Summarize
{
    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);
    class Delegate_1
    {
        //委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，
        //这种将方法动态地赋给参数的做法，可以避免在程序中大量使用If-Else(Switch)语句，
        //同时使得程序具有更好的可扩展性。
        //static void Main(string[] args)
        //{
        //    GreetPeople("Tom", EnglishGreeting);
        //    GreetPeople("小明", ChineseGreeting);
        //    Console.Read();
        //}

        //注意此方法，它接受一个GreetingDelegate类型的方法作为参数
        private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }

        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Moring："+name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好："+name);
        }

    }
}
