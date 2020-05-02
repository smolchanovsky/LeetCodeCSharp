using System.Collections;
using FluentAssertions;
using LeetCode.Helpers;
using LeetCode.Solutions.MergeTwoSortedLists;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class MergeTwoSortedListsTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(
					new LinkedList(new[] {0}).First, 
					new LinkedList(new[] {0}).First,
					new LinkedList(new[] {0, 0}).First)
				.SetDescription("Single values"),
			new TestCaseData(
					new LinkedList(new[] {2, 3, 4}).First, 
					new LinkedList(new[] {4, 5, 6}).First,
					new LinkedList(new[] {2, 3, 4, 4, 5, 6}).First)
				.SetName("Same length lists"),
			new TestCaseData(
					new LinkedList(new[] {2, 3, 4, 6}).First, 
					new LinkedList(new[] {4, 5}).First,
					new LinkedList(new[] {2, 3, 4, 4, 5, 6}).First)
				.SetName("Left list is longer"),
			new TestCaseData(
					new LinkedList(new[] {2, 4}).First, 
					new LinkedList(new[] {4, 5, 6, 7}).First,
					new LinkedList(new[] {2, 4, 4, 5, 6, 7}).First)
				.SetName("Right list is longer"),
			new TestCaseData(
					new LinkedList(new[] {1, 2, 3, 4}).First, 
					new LinkedList(new[] {5, 6, 7, 8}).First,
					new LinkedList(new[] {1, 2, 3, 4, 5, 6, 7, 8}).First)
				.SetName("List items do not repeat"),
		};
		
		private IMergeTwoSortedLists mergeTwoSortedListsApproach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			mergeTwoSortedListsApproach1 = new MergeTwoSortedListsApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Merge(ListNode first, ListNode second, ListNode expectedResult)
		{
			var actualResult = mergeTwoSortedListsApproach1.Merge(first, second);
			
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}