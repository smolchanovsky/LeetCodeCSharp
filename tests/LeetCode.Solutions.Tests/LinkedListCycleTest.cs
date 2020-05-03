using System.Collections;
using FluentAssertions;
using LeetCode.Helpers;
using LeetCode.Solutions.LinkedListCycle;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class LinkedListCycleTest
	{
		private static ListNode NoCycleList 
		{
			get
			{
				return new LinkedList(new[] {1, 2, 3, 4}).First;
			}
		}
		
		private static ListNode CycleListWithOneItem 
		{
			get
			{
				var listNode = new LinkedList(new[] {1}).First;
				listNode.Next = listNode;
				return listNode;
			}
		}
		
		private static ListNode CycleListWithManyItems
		{
			get
			{
				var listNode = new LinkedList(new[] {1, 2, 3, 4}).First;
				listNode.Next.Next.Next = listNode.Next;
				return listNode;
			}
		}
		
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(NoCycleList, false)
				.SetName("No cycle in the linked list"),
			new TestCaseData(CycleListWithOneItem, true)
				.SetName("Cycle in the one-item linked list"),
			new TestCaseData(CycleListWithManyItems, true)
				.SetName("Cycle in the linked list"),
		};

		private ILinkedListCycle approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new LinkedListCycleApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_HasCycle(ListNode head, bool expectedResult)
		{
			var actualResult = approach1.HasCycle(head);

			actualResult.Should().Be(expectedResult);
		}
	}
}