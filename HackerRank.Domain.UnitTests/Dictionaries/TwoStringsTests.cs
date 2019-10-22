using FluentAssertions;
using HackerRank.Domain.Dictionaries;
using Xunit;

namespace HackerRank.Domain.UnitTests.Dictionaries
{
	public class TwoStringsTests
	{
		[Theory]
		[InlineData("hello", "world", "YES")]
		[InlineData("hi", "world", "NO")]
		[InlineData("wouldyoulikefries", "abcabcabcabcabcabc", "NO")]
		[InlineData("hackerrankcommunity", "cdecdecdecde", "YES")]
		[InlineData("jackandjill", "wentupthehill", "YES")]
		[InlineData("writetoyourparents", "fghmqzldbc", "NO")]
		public void T(string s1, string s2, string expected)
		{
			// act
			var result = TwoStrings.TwoStr(s1, s2);

			// assert
			result.Should().BeEquivalentTo(expected);
		}
	}
}
