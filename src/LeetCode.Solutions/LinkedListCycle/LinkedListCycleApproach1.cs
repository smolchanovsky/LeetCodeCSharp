using LeetCode.Helpers;

namespace LeetCode.Solutions.LinkedListCycle
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(1).
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