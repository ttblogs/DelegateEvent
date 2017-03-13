using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCaseOne
{
    // 热水器
    public class Heater
    {
        private int temperature;
        public delegate void BoilHandler(int param);   //声明委托
        public event BoilHandler BoilEvent;        //声明事件

        // 烧水
        public void BoilWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;

                if (temperature > 95)
                {
                    if (BoilEvent != null)
                    { //如果有对象注册
                        BoilEvent(temperature);  //调用所有注册对象的方法
                    }
                }
            }
        }
    }
}
