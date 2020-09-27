namespace LeetCode.Solutions.MergeSortedArray
{
    /// <summary>
	/// Time complexity: O(n + m).
	/// Space complexity: O(1).
	/// Runtime: 232 ms, faster than 94.25% of C# online submissions for Merge Sorted Array.
	/// Memory Usage: 31.1 MB, less than 5.02% of C# online submissions for Merge Sorted Array.
	/// </summary>
    public class MergeSortedArrayApproach1 : IMergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			var resultCurrent = m + n - 1; 
			var mCurrent = m - 1;
			var nCurrent = n - 1;
			while (mCurrent >= 0 || nCurrent >= 0)
			{
				if (nCurrent < 0 && mCurrent >= 0)
					break;

				if (mCurrent < 0 && nCurrent >= 0)
				{
					nums1[resultCurrent--] = nums2[nCurrent--];
					continue;
				}

				if (nums1[mCurrent] > nums2[nCurrent])
					nums1[resultCurrent--] = nums1[mCurrent--];
				else
					nums1[resultCurrent--] = nums2[nCurrent--];
			}
		}
    }
}
