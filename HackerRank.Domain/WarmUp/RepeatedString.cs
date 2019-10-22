using System.Linq;

namespace HackerRank.Domain.WarmUp
{
	public class RepeatedString
	{
		public static long RepeatString(string s, long n)
		{
			var numberOfStringRepeats = n / s.Length;

			var leftString = (int)(n % s.Length);

			var numberOfAInString = s.Count(c => c == 'a');

			var numberOfAInLeftString = s.Substring(0, leftString).Count(c => c == 'a');

			return numberOfStringRepeats * numberOfAInString + numberOfAInLeftString;
		}
	}
}
