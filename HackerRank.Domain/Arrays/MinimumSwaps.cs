using System.Collections.Generic;

namespace HackerRank.Domain.Arrays
{
	public class MinimumSwaps
	{
		public static int MinSwaps(int[] arr)
		{
			var minSwaps = 0;

			var index = 0;
			while (index < arr.Length)
			{
				if (arr[index] != index + 1)
				{
					Swap(arr, index, arr[index] - 1);
					minSwaps++;
				}
				else
				{
					index++;
				}
			}

			return minSwaps;
		}

		private static void Swap(IList<int> array, int firstIndex, int secondIndex)
		{
			var temp = array[firstIndex];

			array[firstIndex] = array[secondIndex];
			array[secondIndex] = temp;
		}
	}
}
