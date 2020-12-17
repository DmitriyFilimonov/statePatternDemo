using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.Fueler
{
    public class DefaultFueler
    {
        int FuelPortion = 10;
        public void Refuel(TestAutomobile car)
        {
            if (car.Fuel > car.FullTank-this.FuelPortion)
            {
                Console.WriteLine("Max fueling");
            }
            else if (car.Fuel < car.FullTank)
            {
                car.Fuel+=FuelPortion;
                Console.WriteLine("Fuel level:" + car.Fuel);
                
            }

        }
    }
}
