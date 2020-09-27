using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.FindMinimumInRotatedSortedArray;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class FindMinimumInRotatedSortedArrayTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(Array.Empty<int>(), -1)
				.SetName("Empty array"),
			new TestCaseData(new[] {1}, 1)
				.SetName("One-item array"),
			new TestCaseData(new[] {1, 2}, 1)
				.SetName("Two-items sorted array"),
			new TestCaseData(new[] {2, 1}, 1)
				.SetName("Two-items rotated array"),
			new TestCaseData(new[] {1, 2, 3, 4, 5}, 1)
				.SetName("Sorted array"),
			new TestCaseData(new[] {4, 5, 6, 1, 2, 3}, 1)
				.SetName("Rotated sorted array split in half"),
			new TestCaseData(new[] {1, 2, 3, 4, 5, 0}, 0)
				.SetName("Rotated sorted array not split in half")
		};

		private IFindMinimumInRotatedSortedArray approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new FindMinimumInRotatedSortedArrayApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_FindMin(int[] nums, int expectedResult)
		{
			var actualResult = approach1.FindMin(nums);

			actualResult.Should().Be(expectedResult);
		}
	}
}
