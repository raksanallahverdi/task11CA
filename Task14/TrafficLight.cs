using System;
namespace Task14
{
	public class TrafficLight
	{
		public Colors Color { get; set; }
		public TrafficLight(Colors color)
		{
			Color = color;
		}
        public void NextColor()
        {
           
            switch (Color)
            {
                case Colors.Red:
                    Console.WriteLine(Colors.Green); 
                    break;
                case Colors.Yellow:
                    Console.WriteLine(Colors.Red);

                    break;
                case Colors.Green:
                    Console.WriteLine(Colors.Yellow);

                    break;
            }
        }
    }
}

