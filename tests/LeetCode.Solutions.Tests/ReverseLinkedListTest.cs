using System.Collections;
using FluentAssertions;
using LeetCode.Helpers;
using LeetCode.Solutions.ReverseLinkedList;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class ReverseLinkedListTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(new LinkedList(new[] {0}).First, new LinkedList(new[] {0}).First)
				.SetName("One-node list"),
			new TestCaseData(new LinkedList(new[] {1, 1, 1, 1, 1}).First, new LinkedList(new[] {1, 1, 1, 1, 1}).First)
				.SetName("One repeating value"),
			new TestCaseData(new LinkedList(new[] {1, 2, 3, 4, 5}).First, new LinkedList(new[] {5, 4, 3, 2, 1}).First)
				.SetName("List of unique values"),
		};

		private IReverseLinkedList approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new ReverseLinkedListApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Reverse(ListNode head, ListNode expectedResult)
		{
			var actualResult = approach1.Reverse(head);

			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}