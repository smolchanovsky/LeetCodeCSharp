using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.RemoveElement
{
    /// <summary>
	/// <see href="https://leetcode.com/problems/remove-element">Remove Element</see>
	/// Given an array nums and a value val, remove all instances of that value in-place and return the new length.
	/// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
	/// The order of elements can be changed.
	/// It doesn't matter what you leave beyond the new length.
	/// </summary>
    public interface IRemoveElement
    {
        int RemoveElement(int[] nums, int val);
    }
}
