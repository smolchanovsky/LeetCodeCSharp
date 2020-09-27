using System;
using LeetCode.Helpers;

namespace LeetCode.Solutions.ReverseLinkedList
{
	/// <summary>
	/// Description: Recursive algorithm.
	/// Time complexity: O(n).
	/// Space complexity: O(n).
	/// Runtime: 88 ms, faster than 93.31% of C# online submissions for Reverse Linked List.
	/// Memory Usage: 25.2 MB, less than 5.14% of C# online submissions for Reverse Linked List.
	/// </summary>
	public class ReverseLinkedListApproach2 : IReverseLinkedList
	{
		public ListNode? Reverse(ListNode head)
		{
			if (head?.Next == null) 
				return head;
			
			var p = Reverse(head.Next);
			head.Next.Next = head;
			head.Next = null;
			return p;
		}
	}
}