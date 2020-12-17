using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.LowFuel
{
    public class FueledIFuel//: IFuel
    {
        
        
        public void Start(TestAutomobile car)
        {
            if (car.Fuel <= 5)
            {
                //car.FuelState = new LowIFuel();
                car.StartEngine();
            }
            else
            {
                car.Fuel -= 5;
                Console.WriteLine("Engine started.");
            }

        }
    }
}
