using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Helpers;
using LeetCode.Solutions.MergeKSortedLists;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class MergeKSortedListsTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(
					Array.Empty<ListNode>(),
					null)
				.SetDescription("Empty list"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {1, 2, 3}).First
					},
					new LinkedList(new[] {1, 2, 3}).First)
				.SetDescription("Single list"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {0}).First,
						new LinkedList(new[] {0}).First,
						new LinkedList(new[] {0}).First
					},
					new LinkedList(new[] {0, 0, 0}).First)
				.SetDescription("Single values"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {3, 4}).First, 
						new LinkedList(new[] {4, 5, 6}).First,
						new LinkedList(new[] {6, 7, 8}).First,
						new LinkedList(new[] {8, 9}).First
					},
					new LinkedList(new[] {3, 4, 4, 5, 6, 6, 7, 8, 8, 9}).First)
				.SetName("Even number of lists"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {2, 3, 4}).First, 
						new LinkedList(new[] {4, 5, 6}).First,
						new LinkedList(new[] {6, 7, 8}).First
					},
					new LinkedList(new[] {2, 3, 4, 4, 5, 6, 6, 7, 8}).First)
				.SetName("Odd number of lists"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {2, 3, 4}).First, 
						new LinkedList(new[] {4, 5, 6}).First,
						new LinkedList(new[] {6, 7, 8}).First
					},
					new LinkedList(new[] {2, 3, 4, 4, 5, 6, 6, 7, 8}).First)
				.SetName("Same length lists"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {2, 3, 4, 6}).First, 
						new LinkedList(new[] {4, 5}).First,
						new LinkedList(new[] {5, 6}).First
					},
					new LinkedList(new[] {2, 3, 4, 4, 5, 5, 6, 6}).First)
				.SetName("First list is longer"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {1, 2}).First,
						new LinkedList(new[] {2, 4}).First,
						new LinkedList(new[] {4, 5, 6, 7}).First
					},
					new LinkedList(new[] {1, 2, 2, 4, 4, 5, 6, 7}).First)
				.SetName("Right list is longer"),
			new TestCaseData(
					new[]
					{
						new LinkedList(new[] {1, 2, 3}).First, 
						new LinkedList(new[] {4, 5, 6}).First,
						new LinkedList(new[] {7, 8, 9}).First
					},
					new LinkedList(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}).First)
				.SetName("Lists items do not repeat"),
		};
		
		private IMergeKSortedLists mergeKSortedListsApproach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			mergeKSortedListsApproach1 = new MergeKSortedListsApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Merge(ListNode[] lists, ListNode expectedResult)
		{
			var actualResult = mergeKSortedListsApproach1.Merge(lists);
			
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}