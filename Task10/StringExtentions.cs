using System;
namespace Task10
{
	public static class StringExtentions
	{
		public static string Capitalize(this string word)
		{
            
            if (string.IsNullOrEmpty(word))
                return word;
            string capitalized = "";
            capitalized += word[0].ToString().ToUpper();
            for (int i = 1; i < word.Length; i++)
            {
                capitalized += word[i];
            }
            return capitalized;
        }

		
	}
}

