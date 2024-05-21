
using System;
namespace Task14
{


    public static class Program
    {
        public static void Main()
        {
            TrafficLight light = new TrafficLight(Colors.Red);
            light.NextColor();
            Console.ReadLine();

        }
    }
}

