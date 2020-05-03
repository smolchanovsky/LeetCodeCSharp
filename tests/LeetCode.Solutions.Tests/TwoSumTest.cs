using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.TwoSum;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class TwoSumTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(Array.Empty<int>(), 2, Array.Empty<int>())
				.SetName("Empty array"),
			new TestCaseData(new[] {1}, 1, Array.Empty<int>())
				.SetName("Array with single item"),
			new TestCaseData(new[] {1, 2}, 3, new[] {0, 1})
				.SetName("Array with two items"),
			new TestCaseData(new[] {1, 2, 3, 5, 4}, 6, new[] {0, 3})
				.SetName("Array with many items"),
			new TestCaseData(new[] {2, 1, 5, 4, 3}, 5, new[] {1, 3})
				.SetName("Target is same as array item"),
			new TestCaseData(new[] {2, 7, 3, -1}, 6, new[] {1, 3})
				.SetName("Array with negative items")
		};
		
		private ITwoSum approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new TwoSumApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Get(int[] nums, int target, int[] expectedResult)
		{
			var actualResult = approach1.Get(nums, target);
			
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}