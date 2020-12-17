using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternDemo.Automobile.LowFuel

{
    public interface IFuel
    {
        void Start(TestAutomobile car);
    }
}
