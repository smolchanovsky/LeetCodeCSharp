using System.Collections.Generic;

namespace LeetCode.Solutions.ContainsDuplicate
{
	/// <summary>
	/// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(n).
	/// Runtime: 108 ms, faster than 86.74% of C# online submissions for Contains Duplicate.
	/// Memory Usage: 32.2 MB, less than 9.54% of C# online submissions for Contains Duplicate.
	/// </summary>
	public class ContainsDuplicateApproach1 : IContainsDuplicate
	{
		public bool Contains(int[] nums)
		{
			var hashSet = new HashSet<int>();
			
			foreach (var num in nums)
			{
				if (hashSet.Contains(num))
					return true;
				hashSet.Add(num);
			}

			return false;
		}
	}
}
