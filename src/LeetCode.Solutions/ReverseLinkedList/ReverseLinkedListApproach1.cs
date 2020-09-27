using LeetCode.Helpers;

namespace LeetCode.Solutions.ReverseLinkedList
{
	/// <summary>
	/// Description: Iterative algorithm.
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// Runtime: 88 ms, faster than 93.31% of C# online submissions for Reverse Linked List.
	/// Memory Usage: 25.1 MB, less than 5.14% of C# online submissions for Reverse Linked List.
	/// </summary>
	public class ReverseLinkedListApproach1 : IReverseLinkedList
	{
		public ListNode? Reverse(ListNode head)
		{
			ListNode? result = null;
			var currentNode = head;

			while (currentNode != null)
			{
				var nextNode = currentNode.Next;
				currentNode.Next = result;
				result = currentNode;
				currentNode = nextNode;
			}

			return result;
		}
	}
}