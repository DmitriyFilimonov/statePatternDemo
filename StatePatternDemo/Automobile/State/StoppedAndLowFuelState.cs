using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.State
{
    class StoppedAndLowFuelState:IState
    {

        public void Start(TestAutomobile car)
        {
            if (car.Fuel >= car.StartFuelPortion)
            {
                car.OverallState = new StoppedAndFueledState();
                car.StartEngine();
            }
            else
            {
                Console.WriteLine("Low fuel.");
            }

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
