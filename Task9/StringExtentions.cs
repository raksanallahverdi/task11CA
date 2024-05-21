using System;
namespace Task9
{
	public static class StringExtentions
	{
		public static void Reverse(this string word)
		{
			string reversed = "";
			for(int i=word.Length-1;i>=0 ; i--)
			{
				reversed += word[i];
			}
			Console.WriteLine(reversed);
		}
	}
}

