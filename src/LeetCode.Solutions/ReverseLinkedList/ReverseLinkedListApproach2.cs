using System;
using LeetCode.Helpers;

namespace LeetCode.Solutions.ReverseLinkedList
{
	/// <summary>
	/// Recursive algorithm.
	/// Time complexity: O(n).
	/// Space complexity: O(n).
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