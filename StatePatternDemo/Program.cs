using System;
using StatePatternDemo.Automobile;

namespace StatePatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestAutomobile car = new TestAutomobile();

            string command = "";

            while (command!="end")
            {
                command = Convert.ToString(Console.ReadLine());

                if(command=="fuel")
                {
                    car.Refuel();
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
