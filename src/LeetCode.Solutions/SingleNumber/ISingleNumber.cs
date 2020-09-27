namespace LeetCode.Solutions.SingleNumber
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/single-number">Single Number</see>
	/// Given a non-empty array of integers, every element appears twice except for one.
	/// Find that single one.
	/// Note: Your algorithm should have a linear runtime complexity.
	/// Could you implement it without using extra memory?
	/// </summary>
    public interface ISingleNumber
    {
        int SingleNumber(int[] nums);
    }
}
