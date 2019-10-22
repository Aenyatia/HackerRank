using FluentAssertions;
using HackerRank.Domain.WarmUp;
using Xunit;

namespace HackerRank.Domain.UnitTests.WarmUp
{
	public class RepeatedStringTests
	{
		[Theory]
		[InlineData("aba", 10L, 7)]
		[InlineData("a", 1000000000000L, 1000000000000L)]
		public void T(string s, long n, long expected)
		{
			// act
			var result = RepeatedString.RepeatString(s, n);

			// assert
			result.Should().Be(expected);
		}
	}
}
