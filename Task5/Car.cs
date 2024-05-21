using System;
namespace Task5
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }


        public void Start()
        {
            Console.WriteLine("Bus started");
        }
        public void Stop()
        {
            Console.WriteLine("Bus stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Bus : Name: {Name},Passenger {Model}");
        }
    }
}

