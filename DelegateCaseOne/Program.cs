using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCaseOne
{
    class Program
    {
        //http://www.tracefact.net/CSharp-Programming/Delegates-and-Events-in-CSharp.aspx
        static void Main()
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();

            heater.BoilEvent += alarm.MakeAlert;    //注册方法
            heater.BoilEvent += (new Alarm()).MakeAlert;   //给匿名对象注册方法
            heater.BoilEvent += Display.ShowMsg;       //注册静态方法

            heater.BoilWater();   //烧水，会自动调用注册过对象的方法

            Console.Read();
        }
    }
}
