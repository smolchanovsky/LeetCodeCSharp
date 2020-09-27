using LeetCode.Helpers;

namespace LeetCode.Solutions.AddTwoNumbers
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/add-two-numbers/">Add Two Numbers</see>
	/// You are given two non-empty linked lists representing two non-negative integers.
	/// The digits are stored in reverse order and each of their nodes contain a single digit.
	/// Add the two numbers and return it as a linked list.
	/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
	/// </summary>
	public interface IAddTwoNumbers
	{
		ListNode Add(ListNode left, ListNode right);
	}
}
