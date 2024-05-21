using System;
namespace Task7
{
	public static class StringExtensions
	{
		public static bool CheckPin(this string pin)
		{
			if (pin != null && pin.Length==7 && pin.ToUpper()==pin)
			{
				return true;

			}
			return false;
		}
	}
}

