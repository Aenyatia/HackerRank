using System;

namespace HackerRank.Domain.Arrays
{
	public class LeftRotation
	{
		public static int[] RotLeft(int[] a, int d)
		{
			var shift = d % a.Length;
			var shiftedArray = new int[a.Length];

			Array.Copy(a, shift, shiftedArray, 0, a.Length - shift);
			Array.Copy(a, 0, shiftedArray, a.Length - shift, shift);

			return shiftedArray;
		}
	}
}
