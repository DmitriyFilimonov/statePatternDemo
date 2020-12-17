using System;
using System.Collections.Generic;
using System.Text;
using StatePatternDemo.Automobile.LowFuel;
using StatePatternDemo.Automobile.EngineResource;

namespace StatePatternDemo.Automobile
{
    public class TestAutomobile
    {
        public IFuel FuelState;
        public int Fuel = 0;
        
        public TestAutomobile()
        {
            FuelState = new FueledIFuel();
        }
        public void Refuel()
        {
            if (Fuel == 40)
            {
                Console.WriteLine("Max fueling");
            }
            else if (Fuel < 40)
            {
                Fuel++;
                Console.WriteLine("Fuel level:" + this.Fuel);
                if (Fuel == 5)
                {
                    FuelState = new FueledIFuel();
                }
            }
            
        }
        public void Start()
        {
            FuelState.Start(this);
        }
    }
}
