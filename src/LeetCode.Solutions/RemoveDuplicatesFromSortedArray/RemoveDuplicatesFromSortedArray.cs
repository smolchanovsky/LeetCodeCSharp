﻿namespace LeetCode.Solutions.RemoveDuplicatesFromSortedArray
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/remove-duplicates-from-sorted-array/">Remove Duplicates from Sorted Array</see>
	/// Given a sorted array numbers, remove the duplicates in-place such that each element appear only once and return the new length.
	/// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
	/// </summary>
	public interface IRemoveDuplicatesFromSortedArray
	{
		int RemoveDuplicates(int[] numbers);
	}
}
