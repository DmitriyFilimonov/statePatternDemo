using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.State
{
    class StoppedAndLowFuelState:IState
    {

        public void Start(TestAutomobile car)
        {
            if (car.Fuel > 0)
            {
                car.Fuel--;
            }
            Console.WriteLine("Low fuel.");

            car.OverallState = new StoppedAndLowFuelState();
        }
        public void PerformEngine(TestAutomobile car)
        {
            
        }

        public void Stop(TestAutomobile car)
        {
            Console.WriteLine("Car is already stopped.");
        }
    }
}
