namespace HackerRank.Domain.WarmUp
{
	public class JumpingOnTheClouds
	{
		public static int JumpingOnClouds(int[] c)
		{
			var jumps = 0;
			var i = 0;

			while (i < c.Length - 1)
			{
				// if 2nd field forward is empty jump there, else do one step
				if (i + 2 < c.Length && c[i + 2] != 1)
					i += 2;
				else
					i++;

				jumps++;
			}

			return jumps;
		}
	}
}
