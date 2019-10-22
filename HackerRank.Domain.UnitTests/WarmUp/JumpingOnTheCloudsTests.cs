using FluentAssertions;
using HackerRank.Domain.WarmUp;
using Xunit;

namespace HackerRank.Domain.UnitTests.WarmUp
{
	public class JumpingOnTheCloudsTests
	{
		[Theory]
		[InlineData(new[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
		[InlineData(new[] { 0, 0, 0, 1, 0, 0 }, 3)]
		public void T(int[] c, int expected)
		{
			// act
			var result = JumpingOnTheClouds.JumpingOnClouds(c);

			// assert
			result.Should().Be(expected);
		}
	}
}
