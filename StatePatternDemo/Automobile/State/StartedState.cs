using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace StatePatternDemo.Automobile.State
{
    public class StartedState : IState
    {
        
        public void Start(TestAutomobile car)
        {
            Console.WriteLine("Car is already started.");
        }
        public void PerformEngine(TestAutomobile car)
        {
            car.Fuel -= car.FuelFlowRate;
            
            Console.WriteLine("Fuel level: " + car.Fuel);


            if (car.Fuel == 0 || Console.ReadLine() == "stop")
            {
                this.Stop(car);
            }
        }
        public void Stop (TestAutomobile car)
        {
            car.OverallState = new StoppedAndLowFuelState();
            Console.WriteLine("Engine stopped.");
        }
    }
}
