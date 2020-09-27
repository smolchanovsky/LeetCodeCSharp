using LeetCode.Helpers;

namespace LeetCode.Solutions.MergeKSortedLists
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/merge-k-sorted-lists/">Merge k Sorted Lists</see>
	/// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
	/// </summary>
	public interface IMergeKSortedLists
	{
		ListNode Merge(ListNode[] lists);
	}
}
