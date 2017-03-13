using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize.Delegate_6
{
    class Delegate_6
    {
        //类似于使用属性对字段进行封装，Event出场了，它封装了委托类型的变量
        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager();
            //gm.greetDelegate = EnglishGreeting;//编译错误
            gm.greetDelegate += EnglishGreeting;
            gm.greetDelegate += ChineseGreeting;

            gm.GreetPeople("Tom");
            Console.Read();
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
