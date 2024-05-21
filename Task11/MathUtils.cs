using System;
namespace Task11
{
	public static class MathUtils
	{
        public static bool CheckPrime(this int number)
        {
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
        }
    }
}