using System;
using System.Collections.Generic;
using System.Text;


using StatePatternDemo.Automobile.State;
using System.Threading;

namespace StatePatternDemo.Automobile
{
    public class TestAutomobile
    {
        public IState OverallState;
        public int Fuel = 0;
        public int StartFuelPortion = 5;
        public int FuelFlowRate = 1;
        public int FullTank = 40;

        public TestAutomobile()
        {
            OverallState = new StoppedAndFueledState();
        }

        public void StartEngine()
        {
            OverallState.Start(this);
        }

        public void PerformEngine()
        {
            while (OverallState is StartedState)
            {
                OverallState.PerformEngine(this);
            }
            return;
        }
        public void StopEngine()
        {
            OverallState.Stop(this);

        }
    }
}
