namespace LeetCode.Solutions.RemoveDuplicatesFromSortedArray
{
	/// <summary>
	/// Time Complexity: O(n).
	/// Space Complexity: O(1).
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
