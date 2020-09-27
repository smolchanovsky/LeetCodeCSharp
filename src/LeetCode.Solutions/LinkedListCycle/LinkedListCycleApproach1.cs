using LeetCode.Helpers;

namespace LeetCode.Solutions.LinkedListCycle
{
	/// <summary>
	/// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// Runtime: 100 ms, faster than 62.31% of C# online submissions for Linked List Cycle.
	/// Memory Usage: 26.4 MB, less than 23.11% of C# online submissions for Linked List Cycle.
	/// </summary>
	public class LinkedListCycleApproach1 : ILinkedListCycle
	{
		public bool HasCycle(ListNode head)
		{
			if (head?.Next == null)
				return false;
			
			var slowPointer = head;
			var fastPointer = head.Next;
			
			while (slowPointer != fastPointer)
			{
				if (fastPointer?.Next == null)
					return false;

				slowPointer = slowPointer.Next!;
				fastPointer = fastPointer.Next.Next;
			}

			return true;
		}
	}
}