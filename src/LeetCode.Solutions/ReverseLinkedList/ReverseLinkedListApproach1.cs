using LeetCode.Helpers;

namespace LeetCode.Solutions.ReverseLinkedList
{
	/// <summary>
	/// Iterative algorithm.
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// </summary>
	public class ReverseLinkedListApproach1 : IReverseLinkedList
	{
		public ListNode Reverse(ListNode head)
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

			return result!;
		}
	}
}