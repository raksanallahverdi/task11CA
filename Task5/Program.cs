using System;
namespace Task5
{


    public static class Program
    {
        public static void Main()
        {
            Car bmw = new Car("escalade","new car model");
            Motocycle motor = new Motocycle(" sedan", 2021);
            Bus yuzaltmish = new Bus("160", 90);

            bmw.Start();
            motor.GetDetails();
            yuzaltmish.Stop();


        }
    }

}

