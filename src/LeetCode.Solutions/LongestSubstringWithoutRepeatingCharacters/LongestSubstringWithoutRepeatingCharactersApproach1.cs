using System.Collections.Generic;

namespace LeetCode.Solutions.LongestSubstringWithoutRepeatingCharacters
{
	/// <summary>
	/// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(min(m, n)) where N is the size of the string and M is the size of the charset/alphabet.
	/// Runtime: 180 ms, faster than 29.69% of C# online submissions for Longest Substring Without Repeating Characters.
	/// Memory Usage: 26.7 MB, less than 5.04% of C# online submissions for Longest Substring Without Repeating Characters.
	/// </summary>
	public class LongestSubstringWithoutRepeatingCharactersApproach1 : ILongestSubstringWithoutRepeatingCharacters
	{
		public int GetLength(string str)
		{
			var indicesByChars = new Dictionary<char, int>();
			var maxLength = 0;
			
			for (var currentIndex = 0; currentIndex < str.Length; currentIndex++)
			{
				var character = str[currentIndex];
				
				if (indicesByChars.TryGetValue(character, out var rollbackIndex))
				{
					indicesByChars.Clear();
					currentIndex = rollbackIndex;
					continue;
				}

				indicesByChars[character] = currentIndex;

				if (indicesByChars.Count > maxLength)
					maxLength = indicesByChars.Count;
			}

			return maxLength;
		}
	}
}
