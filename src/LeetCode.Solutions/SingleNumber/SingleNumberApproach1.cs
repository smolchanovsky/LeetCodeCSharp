using System;
using System.Linq;

namespace LeetCode.Solutions.SingleNumber
{
	/// <summary>
	/// Description:
	/// Time complexity: O(n * log(n)).
	/// Space complexity: O(1).
	/// Runtime: Runtime: 112 ms, faster than 45.04% of C# online submissions for Single Number.
	/// Memory Usage: Memory Usage: 27 MB, less than 34.01% of C# online submissions for Single Number.
	/// </summary>
    public class SingleNumberApproach1 : ISingleNumber
    {
        public int SingleNumber(int[] nums)
		{
			if (nums.Length == 1)
				return nums.Single();
			
            Array.Sort(nums);
			
			for (var i = 0; i < nums.Length - 1; i += 2)
			{
				if (nums[i] != nums[i + 1])
					return nums[i];
			}

			return nums.Last();
		}
    }
}
