using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.ContainsDuplicate;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class ContainsDuplicateTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(Array.Empty<int>(), false)
				.SetName("Empty array"),
			new TestCaseData(new[] {1}, false)
				.SetName("One-item array"),
			new TestCaseData(new[] {1, 1, 1, 1, 1}, true)
				.SetName("Array consisting of the same repeating value"),
			new TestCaseData(new[] {1, 2, 3, 4, 5}, false)
				.SetName("Array of unique values"),
			new TestCaseData(new[] {1, 2, 2, 3, 4}, true)
				.SetName("Array with nearby duplicates"),
			new TestCaseData(new[] {1, 2, 3, 1, 5}, true)
				.SetName("Array with duplicates"),
			new TestCaseData(new[] {1, 2, 2, 1, 5}, true)
				.SetName("Array with two duplicates"),
		};

		private IContainsDuplicate approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new ContainsDuplicateApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Contains(int[] nums, bool expectedResult)
		{
			var actualResult = approach1.Contains(nums);

			actualResult.Should().Be(expectedResult);
		}
	}
}