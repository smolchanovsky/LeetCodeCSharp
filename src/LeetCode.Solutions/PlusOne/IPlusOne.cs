using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.PlusOne
{
    /// <summary>
	/// <see href="https://leetcode.com/problems/plus-one">Plus One</see>
	/// Given a non-empty array of digits representing a non-negative integer, increment one to the integer.
	/// The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
	/// You may assume the integer does not contain any leading zero, except the number 0 itself.
	/// </summary>
    public interface IPlusOne
    {
        int[] PlusOne(int[] digits);
    }
}