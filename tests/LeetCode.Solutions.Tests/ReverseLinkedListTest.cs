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
		private static IEnumerable TestCases
		{
			get
			{
				yield return new TestCaseData(null, null)
					.SetName("Null value");
				yield return new TestCaseData(
						new LinkedList(new[] {0}).First, 
						new LinkedList(new[] {0}).First)
					.SetName("One-node list");
				yield return new TestCaseData(
						new LinkedList(new[] {1, 1, 1, 1, 1}).First,
						new LinkedList(new[] {1, 1, 1, 1, 1}).First)
					.SetName("One repeating value");
				yield return new TestCaseData(
						new LinkedList(new[] {1, 2, 3, 4, 5}).First, 
						new LinkedList(new[] {5, 4, 3, 2, 1}).First)
					.SetName("List of unique values");
			}
		}

		private IReverseLinkedList approach1;
		private IReverseLinkedList approach2;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new ReverseLinkedListApproach1();
			approach2 = new ReverseLinkedListApproach2();
		}

		[TestCaseSource(nameof(TestCases))]
		public void Approach1_Reverse(ListNode head, ListNode expectedResult)
		{
			var actualResult = approach1.Reverse(head);

			actualResult.Should().BeEquivalentTo(expectedResult);
		}
		
		[TestCaseSource(nameof(TestCases))]
		public void Approach2_Reverse(ListNode head, ListNode expectedResult)
		{
			var actualResult = approach2.Reverse(head);

			actualResult.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
		}
	}
}