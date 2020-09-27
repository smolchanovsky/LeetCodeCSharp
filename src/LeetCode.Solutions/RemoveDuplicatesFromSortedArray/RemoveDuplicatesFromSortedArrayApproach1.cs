namespace LeetCode.Solutions.RemoveDuplicatesFromSortedArray
{
	/// <summary>
	/// Description: 
	/// Time Complexity: O(n).
	/// Space Complexity: O(1).
	/// Runtime: 244 ms, faster than 93.23% of C# online submissions for Remove Duplicates from Sorted Array.
	/// Memory Usage: 34.2 MB, less than 5.04% of C# online submissions for Remove Duplicates from Sorted Array.
	/// </summary>
	public class RemoveDuplicatesFromSortedArrayApproach1 : IRemoveDuplicatesFromSortedArray
	{
		public int RemoveDuplicates(int[] numbers)
		{
			if (numbers.Length == 0)
				return 0;

			var newIndex = 0;
			for (var i = 1; i < numbers.Length; i++)
			{
				if (numbers[newIndex] == numbers[i]) 
					continue;
				
				++newIndex;
				numbers[newIndex] = numbers[i];
			}

			return newIndex + 1;
		}
	}
}
