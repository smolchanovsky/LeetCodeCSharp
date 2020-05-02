using LeetCode.Helpers;

namespace LeetCode.Solutions.MergeTwoSortedLists
{
	/// <summary>
	/// Iterative algorithm.
	/// TTime complexity: O(max(N,M)) where N and M represents the length of first and second respectively.
	/// Space complexity: O(1).
	/// </summary>
	public class MergeTwoSortedListsApproach1: IMergeTwoSortedLists
	{
		public ListNode Merge(ListNode first, ListNode second)
		{
			var root = new ListNode();
			var currentResult = root;
			ListNode? currentFirst = first;
			ListNode? currentSecond = second;

			while (currentFirst != null || currentSecond != null)
			{
				if (currentFirst == null || currentFirst.Value > currentSecond?.Value)
				{
					currentResult.Next = currentSecond!;
					currentResult = currentResult.Next;
					currentSecond = currentSecond!.Next;
					continue;
				}

				if (currentSecond == null || currentFirst?.Value <= currentSecond.Value)
				{
					currentResult.Next = currentFirst!;
					currentResult = currentResult.Next;
					currentFirst = currentFirst!.Next;
					continue;
				}
			}

			return root.Next!;
		}
	}
}