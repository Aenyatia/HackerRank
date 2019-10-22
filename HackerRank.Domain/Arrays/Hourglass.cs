namespace HackerRank.Domain.Arrays
{
	public class Hourglass
	{
		public static int HourglassSum(int[][] arr)
		{
			var maxSum = -63;

			for (var i = 0; i < 4; i++)
			{
				for (var j = 0; j < 4; j++)
				{
					var sum = 0;

					// top 3 elements
					sum += arr[i][j] + arr[i][j + 1] + arr[i][j + 2];

					// mid element
					sum += arr[i + 1][j + 1];

					// bottom 3 elements
					sum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

					if (sum > maxSum)
						maxSum = sum;
				}
			}

			return maxSum;
		}
	}
}
