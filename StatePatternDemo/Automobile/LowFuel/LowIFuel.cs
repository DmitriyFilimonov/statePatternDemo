using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.LowFuel
{
    public class LowIFuel: IFuel
    {
        public void Start(TestAutomobile car)
        {
            if (car.Fuel > 0)
            {
                car.Fuel--;
            }
            Console.WriteLine("Low fuel.");
        }
    }
}
