using FluentAssertions;
using HackerRank.Domain.Arrays;
using Xunit;

namespace HackerRank.Domain.UnitTests.Arrays
{
	public class MinimumSwapsTests
	{
		[Theory]
		[InlineData(new[] { 4, 3, 1, 2 }, 3)]
		[InlineData(new[] { 2, 3, 4, 1, 5 }, 3)]
		[InlineData(new[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
		public void T(int[] arr, int expected)
		{
			// act
			var result = MinimumSwaps.MinSwaps(arr);

			// result
			result.Should().Be(expected);
		}
	}
}
