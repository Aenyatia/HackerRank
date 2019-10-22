using FluentAssertions;
using HackerRank.Domain.WarmUp;
using Xunit;

namespace HackerRank.Domain.UnitTests.WarmUp
{
	public class CountingValleysTests
	{
		[Theory]
		[InlineData("UDDDUDUU", 8, 1)]
		[InlineData("DDUUDDUDUUUD", 12, 2)]
		public void T(string s, int n, int expected)
		{
			// act
			var result = CountingValleys.CountValleys(n, s);

			// assert
			result.Should().Be(expected);
		}
	}
}
