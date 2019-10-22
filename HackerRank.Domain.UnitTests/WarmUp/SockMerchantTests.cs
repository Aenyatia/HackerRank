using FluentAssertions;
using HackerRank.Domain.WarmUp;
using Xunit;

namespace HackerRank.Domain.UnitTests.WarmUp
{
	public class SockMerchantTests
	{
		[Theory]
		[InlineData(new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
		[InlineData(new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, 4)]
		public void T1(int[] ar, int expected)
		{
			// act
			var result = SockMerchant.SockMer(ar);

			// assert
			result.Should().Be(expected);
		}
	}
}
