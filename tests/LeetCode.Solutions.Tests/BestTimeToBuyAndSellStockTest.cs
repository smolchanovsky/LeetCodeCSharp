using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.BestTimeToBuyAndSellStock;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class BestTimeToBuyAndSellStockTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(Array.Empty<int>(), 0)
				.SetName("Empty sequence"),
			new TestCaseData(new[] {1}, 0)
				.SetName("One-item sequence"),
			new TestCaseData(new[] {1, 1, 1, 1, 1}, 0)
				.SetName("Sequence consisting of the same repeating value"),
			new TestCaseData(new[] {1, 2, 3, 4, 5}, 4)
				.SetName("Sequence is strictly monotonic increasing"),
			new TestCaseData(new[] {5, 4, 3, 2, 1}, 0)
				.SetName("Sequence is strictly monotonic decreasing"),
			new TestCaseData(new[] {7, 1, 5, 3, 6, 4}, 5)
				.SetName("Profit sequence"),
		};

		private IBestTimeToBuyAndSellStock approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new BestTimeToBuyAndSellStockApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_GetMaxProfit(int[] nums, int expectedResult)
		{
			var actualResult = approach1.GetMaxProfit(nums);

			actualResult.Should().Be(expectedResult);
		}
	}
}