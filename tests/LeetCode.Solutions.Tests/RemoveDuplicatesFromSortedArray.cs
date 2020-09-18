using System;
using System.Collections;
using System.Linq;
using FluentAssertions;
using LeetCode.Solutions.RemoveDuplicatesFromSortedArray;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class RemoveDuplicatesFromSortedArray
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(Array.Empty<int>(), Array.Empty<int>())
				.SetName("Empty array"),
			new TestCaseData(new[] {1}, new[] {1})
				.SetName("One-item array"),
			new TestCaseData(new[] {0, 1, 2, 3, 4}, new[] {0, 1, 2, 3, 4})
				.SetName("Array without duplicates"),
			new TestCaseData(new[] {0, 1, 1, 2, 3, 3}, new[] {0, 1, 2, 3})
				.SetName("Array with duplicates"),
			new TestCaseData(new[] {1, 1, 1, 1, 1}, new[] {1})
				.SetName("Array with the same elements"),
			new TestCaseData(new[] {-2, -2, -1, 0, 1, 2, 3, 3}, new[] {-2, -1, 0, 1, 2, 3})
				.SetName("Array with negative numbers")
		};

		private IRemoveDuplicatesFromSortedArray approach1;

		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new RemoveDuplicatesFromSortedArrayApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_RemoveDuplicates(int[] numbers, int[] expectedArray)
		{
			var actualArrayLength = approach1.RemoveDuplicates(numbers);
			var actualArray = numbers.Take(actualArrayLength).ToArray();

			actualArrayLength.Should().Be(expectedArray.Length);
			actualArray.Should().BeEquivalentTo(expectedArray);
		}
	}
}
