using System.Collections.Generic;

namespace HackerRank.Domain.Dictionaries
{
	public class RansomNote
	{
		public static string CheckMagazine(string[] magazine, string[] note)
		{
			var magazineWords = new Dictionary<string, int>();

			// create list of unique words with their occurrences
			foreach (var word in magazine)
			{
				if (magazineWords.ContainsKey(word))
					magazineWords[word]++;
				else
					magazineWords.Add(word, 1);
			}

			foreach (var word in note)
			{
				if (!magazineWords.ContainsKey(word) ||
					magazineWords[word] == 0)
					return "NO";

				magazineWords[word]--;
			}

			return "YES";
		}
	}
}
