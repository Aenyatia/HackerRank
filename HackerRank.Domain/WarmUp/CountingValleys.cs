namespace HackerRank.Domain.WarmUp
{
	public class CountingValleys
	{
		public static int CountValleys(int n, string s)
		{
			var valleys = 0;
			var currentHeight = 0;
			var nextHeight = 0;

			foreach (var step in s)
			{
				if (step == 'U')
					nextHeight++;
				else
					nextHeight--;

				if (currentHeight == 0 && nextHeight == -1)
					valleys++;

				currentHeight = nextHeight;
			}

			return valleys;
		}
	}
}
