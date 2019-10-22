using FluentAssertions;
using HackerRank.Domain.Arrays;
using Xunit;

namespace HackerRank.Domain.UnitTests.Arrays
{
	public class NewYearChaosTests
	{
		[Theory]
		[InlineData(new[] { 2, 1, 5, 3, 4 }, "3")]
		[InlineData(new[] { 2, 5, 1, 3, 4 }, "Too chaotic")]
		[InlineData(new[] { 5, 1, 2, 3, 7, 8, 6, 4 }, "Too chaotic")]
		[InlineData(new[] { 1, 2, 5, 3, 7, 8, 6, 4 }, "7")]
		[InlineData(new[] { 1, 2, 5, 3, 4, 7, 8, 6 }, "4")]
		public void T(int[] q, string expected)
		{
			// act
			var result = NewYearChaos.MinimumBribes(q);

			// result
			result.Should().Be(expected);
		}
	}
}
