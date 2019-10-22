using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Domain.Dictionaries
{
	public class TwoStrings
	{
		public static string TwoStr(string s1, string s2)
		{
			var uniqueChars = new HashSet<char>();

			foreach (var c in s1)
				uniqueChars.Add(c);

			return s2.Any(c => uniqueChars.Contains(c)) ? "YES" : "NO";
		}
	}
}
