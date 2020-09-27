using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.TwoSum
{
	/// <summary>
	/// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(n).
	/// Runtime: 228 ms, faster than 99.65% of C# online submissions for Two Sum.
	/// Memory Usage: 32 MB, less than 5.01% of C# online submissions for Two Sum.
	/// </summary>
	public class TwoSumApproach1 : ITwoSum
	{
		public int[] Get(int[] nums, int target)
		{
			var indicesByNums = new Dictionary<int, int>();
			
			for (var left = 0; left < nums.Length; left++)
			{
				if (indicesByNums.TryGetValue(target - nums[left], out var right))
					return new[] {left, right};
				indicesByNums[nums[left]] = left;
			}

			return Array.Empty<int>();
		}
	}
}
