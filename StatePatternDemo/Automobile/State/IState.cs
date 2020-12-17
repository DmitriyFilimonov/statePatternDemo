using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.State
{
    public interface IState
    {
        void Start(TestAutomobile car);
        void PerformEngine(TestAutomobile car);
        void Stop(TestAutomobile car);
    }
}
