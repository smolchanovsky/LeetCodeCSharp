using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.TwoSum
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(n).
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