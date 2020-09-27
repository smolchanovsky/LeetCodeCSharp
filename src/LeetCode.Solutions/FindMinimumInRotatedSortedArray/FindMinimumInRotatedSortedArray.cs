namespace LeetCode.Solutions.FindMinimumInRotatedSortedArray
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/">Find Minimum in Rotated Sorted Array</see>
	/// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
	/// (i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).
	/// Find the minimum element.
	/// You may assume no duplicate exists in the array.
	/// </summary>
	public interface IFindMinimumInRotatedSortedArray
	{
		int FindMin(int[] nums);
	}
}
