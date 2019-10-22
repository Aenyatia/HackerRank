using System;

namespace HackerRank.Domain.Arrays
{
	public class NewYearChaos
	{
		public static string MinimumBribes(int[] q)
		{
			var bribes = 0;

			for (var i = q.Length - 1; i >= 0; i--)
			{
				// if someone bribed more then two people, print 'Too chaotic'
				if (q[i] - (i + 1) > 2)
				{
					return "Too chaotic";
				}

				// if number on left side from q[i] is grater then q[i] that means we have a bribe
				// [ 1, 2, 5, 3, 7, 8, 6, 4 ] means 4 was bribed by 5, 7, 8, 6
				//									6 was bribed by 7, 8
				//									3 was bribed by 5
				for (var j = Math.Max(0, q[i] - 2); j < i; j++)
				{
					if (q[j] > q[i])
						bribes++;
				}
			}

			return bribes.ToString();
		}
	}
}
