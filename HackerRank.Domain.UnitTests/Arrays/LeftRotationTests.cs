using FluentAssertions;
using HackerRank.Domain.Arrays;
using Xunit;

namespace HackerRank.Domain.UnitTests.Arrays
{
	public class LeftRotationTests
	{
		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 5, 1, 2, 3, 4 })]
		[InlineData(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
		[InlineData(new[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, new[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
		public void T(int[] a, int d, int[] expected)
		{
			// act
			var result = LeftRotation.RotLeft(a, d);

			// assert
			result.Should().BeEquivalentTo(expected);
		}
	}
}
