using System;
namespace Task6
{
	public static class StringExtentions
	{
		public static bool CheckPolindrome(this string word)
		{
            string reversed = new string(word.Reverse().ToArray());
			if (reversed == word)
			{
				return true;
			}
			return false;
        }
	}
}

