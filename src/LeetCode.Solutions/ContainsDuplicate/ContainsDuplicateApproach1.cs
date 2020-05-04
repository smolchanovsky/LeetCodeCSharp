using System.Collections.Generic;

namespace LeetCode.Solutions.ContainsDuplicate
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(n).
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