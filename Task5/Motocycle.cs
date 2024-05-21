using System;
namespace Task5
{
	public class Motocycle:IVehicle
	{
        public string Name { get; set; }
        public int Year { get; set; }
        public Motocycle(string name,int year)
		{
            Name = name;
            Year = year;
		}
		public void Start()
		{
			Console.WriteLine("Motocycle started");
		}
        public void Stop()
        {
            Console.WriteLine("Motocycle stopped");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Motocycle : Name: {Name},Year {Year}");
        }
    }
}

