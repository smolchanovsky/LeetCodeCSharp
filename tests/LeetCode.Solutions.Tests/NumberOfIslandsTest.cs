using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.NumberOfIslands;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class NumberOfIslandsTest
	{
		private static char[][] ZeroIslandGrid => new[]
		{
			new [] {'0', '0', '0', '0'},
			new [] {'0', '0', '0', '0'},
			new [] {'0', '0', '0', '0'},
			new [] {'0', '0', '0', '0'}
		};
		
		private static char[][] IslandOnWholeGrid => new[]
		{
			new [] {'1', '1', '1', '1'},
			new [] {'1', '1', '1', '1'},
			new [] {'1', '1', '1', '1'},
			new [] {'1', '1', '1', '1'},
		};
		
		private static char[][] OneIslandGrid => new[]
		{
			new [] {'1', '1', '1', '1', '0'},
			new [] {'1', '1', '0', '1', '0'},
			new [] {'1', '1', '0', '0', '0'},
			new [] {'0', '0', '0', '0', '0'}
		};

		private static char[][] ThreeIslandGrid => new[]
		{
			new [] {'1', '1', '0', '0', '0'},
			new [] {'1', '1', '0', '0', '0'},
			new [] {'0', '0', '1', '0', '0'},
			new [] {'0', '0', '0', '1', '1'}
		};
		
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(ZeroIslandGrid, 0)
				.SetName("Zero island grid"),
			new TestCaseData(IslandOnWholeGrid, 1)
				.SetName("Island on whole grid"),
			new TestCaseData(OneIslandGrid, 1)
				.SetName("One island grid"),
			new TestCaseData(ThreeIslandGrid, 3)
				.SetName("Three island grid")
		};

		private INumberOfIslands approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new NumberOfIslandsApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Get(char[][] grid, int expectedResult)
		{
			var actualResult = approach1.Get(grid);

			actualResult.Should().Be(expectedResult);
		}
	}
}