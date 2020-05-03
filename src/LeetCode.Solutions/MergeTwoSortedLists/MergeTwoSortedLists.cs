using LeetCode.Helpers;

namespace LeetCode.Solutions.MergeTwoSortedLists
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/merge-two-sorted-lists/">Merge Two Sorted Lists</see>
	/// Merge two sorted linked lists and return it as a new list.
	/// The new list should be made by splicing together the nodes of the first two lists.
	/// </summary>
	public interface IMergeTwoSortedLists
	{
		ListNode Merge(ListNode first, ListNode second);
	}
}