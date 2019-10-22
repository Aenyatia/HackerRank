using FluentAssertions;
using HackerRank.Domain.Arrays;
using Xunit;

namespace HackerRank.Domain.UnitTests.Arrays
{
	public class ArrayManipulationTests
	{
		[Fact]
		public void T1()
		{
			// arrange
			const int n = 5;
			var queries = new[]
			{
				new []{ 1, 2, 100 },
				new []{ 2, 5, 100 },
				new []{ 3, 4, 100 }
			};

			const int expected = 200;

			// act
			var result = ArrayManipulation.ArrManipulation(n, queries);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T2()
		{
			// arrange
			const int n = 10;
			var queries = new[]
			{
				new []{ 1, 5, 3 },
				new []{ 4, 8, 7 },
				new []{ 6, 9, 1 }
			};

			const int expected = 10;

			// act
			var result = ArrayManipulation.ArrManipulation(n, queries);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T3()
		{
			// arrange
			const int n = 10;
			var queries = new[]
			{
				new []{ 2, 6, 8 },
				new []{ 3, 5, 7 },
				new []{ 1, 8, 1 },
				new []{ 5, 9, 15 }
			};

			const int expected = 31;

			// act
			var result = ArrayManipulation.ArrManipulation(n, queries);

			// assert
			result.Should().Be(expected);
		}
	}
}
