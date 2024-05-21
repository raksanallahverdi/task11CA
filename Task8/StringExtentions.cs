using System;
namespace Task8
{
	public static class StringExtentions
	{
		public static void FindAverage(this int[] array)
		{
			float sum = 0;
			foreach(var number in array)
			{
				sum += number;
			}
			Console.WriteLine(sum / array.Length);
		}
	}
}

