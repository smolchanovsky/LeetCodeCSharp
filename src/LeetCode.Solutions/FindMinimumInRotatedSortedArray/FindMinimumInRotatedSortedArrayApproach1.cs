using System.Linq;

namespace LeetCode.Solutions.FindMinimumInRotatedSortedArray
{
	/// <summary>
	/// Binary Search.
	/// Time Complexity: O(logN).
	/// Space Complexity: O(1).
	/// </summary>
	public class FindMinimumInRotatedSortedArrayApproach1 : IFindMinimumInRotatedSortedArray
	{
		public int FindMin(int[] nums)
		{
			if (nums.Length == 1)
				return nums[0];
			if (nums.LastOrDefault() > nums.FirstOrDefault()) 
				return nums[0];
			
			var left = 0;
			var right = nums.Length - 1;

			while (left <= right)
			{
				var middle = left + (right - left) / 2;
				
				if (nums[middle] < nums[middle - 1])
					return nums[middle];
				if (nums[middle] > nums[middle + 1])
					return nums[middle + 1];

				if (nums[middle] > nums[0])
					left = middle + 1;
				else
					right = middle - 1;
			}

			return -1;
		}
	}
}