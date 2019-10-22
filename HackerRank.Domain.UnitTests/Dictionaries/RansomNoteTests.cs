using FluentAssertions;
using HackerRank.Domain.Dictionaries;
using Xunit;

namespace HackerRank.Domain.UnitTests.Dictionaries
{
	public class RansomNoteTests
	{
		[Theory]
		[InlineData(new[] { "give", "me", "one", "grand", "today", "night" }, new[] { "give", "one", "grand", "today" }, "Yes")]
		[InlineData(new[] { "two", "times", "three", "is", "not", "four" }, new[] { "two", "times", "two", "is", "four" }, "No")]
		[InlineData(new[] { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" }, new[] { "ive", "got", "some", "coconuts" }, "No")]

		public void T(string[] magazine, string[] note, string expected)
		{
			// act
			var result = RansomNote.CheckMagazine(magazine, note);

			// assert
			result.Should().BeEquivalentTo(expected);
		}
	}
}
