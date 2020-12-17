using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.State
{
    public class StoppedAndFueledState: IState
    {
        public void Start(TestAutomobile car)
        {
            if (car.Fuel <= car.StartFuelPortion)
            {
                car.OverallState = new StoppedAndLowFuelState();
                car.StartEngine();
            }
            else
            {
                car.Fuel -= car.StartFuelPortion;
                car.OverallState = new StartedState();
                Console.WriteLine("Engine started.");
                car.PerformEngine();
            }
        }
        public void PerformEngine(TestAutomobile car)
        {
            
        }
        public void Stop(TestAutomobile car)
        {
            Console.WriteLine("Car is not started.");
        }
    }
}
