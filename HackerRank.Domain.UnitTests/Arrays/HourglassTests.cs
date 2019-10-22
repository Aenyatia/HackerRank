using FluentAssertions;
using HackerRank.Domain.Arrays;
using Xunit;

namespace HackerRank.Domain.UnitTests.Arrays
{
	public class HourglassTests
	{
		[Fact]
		public void T1()
		{
			// arrange
			var arr = new[]
			{
				new[] { -9, -9, -9, -9, -9, -9 },
				new[] { -9, -9, -9, -9, -9, -9 },
				new[] { -9, -9, -9, -9, -9, -9 },
				new[] { -9, -9, -9, -9, -9, -9 },
				new[] { -9, -9, -9, -9, -9, -9 },
				new[] { -9, -9, -9, -9, -9, -9 }
			};

			const int expected = -63;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T2()
		{
			// arrange
			var arr = new[]
			{
				new[] { 0, 0, 0, 0, 0, 0 },
				new[] { 0, 0, 0, 0, 0, 0 },
				new[] { 0, 0, 0, 0, 0, 0 },
				new[] { 0, 0, 0, 0, 0, 0 },
				new[] { 0, 0, 0, 0, 0, 0 },
				new[] { 0, 0, 0, 0, 0, 0 }
			};

			const int expected = 0;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T3()
		{
			// arrange
			var arr = new[]
			{
				new[] { 9, 9, 9, 9, 9, 9 },
				new[] { 9, 9, 9, 9, 9, 9 },
				new[] { 9, 9, 9, 9, 9, 9 },
				new[] { 9, 9, 9, 9, 9, 9 },
				new[] { 9, 9, 9, 9, 9, 9 },
				new[] { 9, 9, 9, 9, 9, 9 }
			};

			const int expected = 63;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T4()
		{
			// arrange
			var arr = new[]
			{
				new[] { 1, 1, 1, 0, 0, 0 },
				new[] { 0, 1, 0, 0, 0, 0 },
				new[] { 1, 1, 1, 0, 0, 0 },
				new[] { 0, 0, 2, 4, 4, 0 },
				new[] { 0, 0, 0, 2, 0, 0 },
				new[] { 0, 0, 1, 2, 4, 0 }
			};

			const int expected = 19;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T5()
		{
			// arrange
			var arr = new[]
			{
				new[] { 1, 1, 1, 0, 0, 0 },
				new[] { 0, 1, 0, 0, 0, 0 },
				new[] { 1, 1, 1, 0, 0, 0 },
				new[] { 0, 9, 2, -4, -4, 0 },
				new[] { 0, 0, 0, -2, 0, 0 },
				new[] { 0, 0, -1, -2, -4, 0 }
			};

			const int expected = 13;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}

		[Fact]
		public void T6()
		{
			// arrange
			var arr = new[]
			{
				new[] { -9, -9, -9, 1, 1, 1 },
				new[] { 0, -9, 0, 4, 3, 2 },
				new[] { -9, -9, -9, 1, 2, 3 },
				new[] { 0, 0, 8, 6, 6, 0 },
				new[] { 0, 0, 0, -2, 0, 0 },
				new[] { 0, 0, 1, 2, 4, 0 }
			};

			const int expected = 28;

			// act
			var result = Hourglass.HourglassSum(arr);

			// assert
			result.Should().Be(expected);
		}
	}
}
