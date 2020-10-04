namespace LeetCode.Solutions.RemoveElement
{
    /// <summary>
    /// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// Runtime: Runtime: 228 ms, faster than 97.92% of C# online submissions for Remove Element.
	/// Memory Usage: 30.9 MB, less than 5.30% of C# online submissions for Remove Element.
	/// </summary>
    public class RemoveElementApproach1 : IRemoveElement
    {
        public int RemoveElement(int[] nums, int val)
		{
			var newIndex = 0;
			for (var i = 0; i < nums.Length; i++)
			{
				if (nums[i] != val)
					nums[newIndex++] = nums[i];
			}

			return newIndex;
		}
    }
}
