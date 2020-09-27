using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.MergeSortedArray
{
    /// <summary>
	/// <see href="https://leetcode.com/problems/merge-sorted-array">Merge Sorted Array</see>
	/// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
	/// Note:
	/// The number of elements initialized in nums1 and nums2 are m and n respectively.
	/// You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
	/// </summary>
    public interface IMergeSortedArray
    {
        void Merge(int[] nums1, int m, int[] nums2, int n);
    }
}
