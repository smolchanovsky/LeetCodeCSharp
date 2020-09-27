using LeetCode.Helpers;

namespace LeetCode.Solutions.MergeTwoSortedLists
{
	/// <summary>
	/// Description: 
	/// Iterative algorithm.
	/// TTime complexity: O(max(n, m)) where N and M represents the length of first and second respectively.
	/// Space complexity: O(1).
	/// Runtime: 96 ms, faster than 66.25% of C# online submissions for Merge Two Sorted Lists.
	/// Memory Usage: 26.5 MB, less than 5.11% of C# online submissions for Merge Two Sorted Lists.
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
