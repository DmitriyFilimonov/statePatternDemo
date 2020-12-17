using System;
using StatePatternDemo.Automobile;
using StatePatternDemo.Automobile.Fueler;

namespace StatePatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestAutomobile car = new TestAutomobile();
            DefaultFueler fueler = new DefaultFueler();

            string command = "";

            while (command!="end")
            {
                command = Convert.ToString(Console.ReadLine());

                if(command=="fuel")
                {
                    fueler.Refuel(car);
                }

                if (command=="start")
                {
                    car.StartEngine();
                }
                if (command=="stop")
                {
                    car.StopEngine();
                }
            }
        }
    }
}
