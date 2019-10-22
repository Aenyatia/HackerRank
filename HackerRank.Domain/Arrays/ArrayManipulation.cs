namespace HackerRank.Domain.Arrays
{
	public class ArrayManipulation
	{
		public static long ArrManipulation(int n, int[][] queries)
		{
			var resultArray = new long[n + 1];

			foreach (var query in queries)
			{
				long startIndex = query[0];
				long endIndex = query[1];
				long numberToSum = query[2];

				resultArray[startIndex] += numberToSum;

				if (endIndex + 1 <= n)
				{
					resultArray[endIndex + 1] -= numberToSum;
				}
			}

			long maxValue = 0;
			long prefixSum = 0;

			for (var i = 1; i < resultArray.Length; i++)
			{
				prefixSum += resultArray[i];

				if (prefixSum > maxValue)
				{
					maxValue = prefixSum;
				}
			}

			return maxValue;
		}
	}
}
