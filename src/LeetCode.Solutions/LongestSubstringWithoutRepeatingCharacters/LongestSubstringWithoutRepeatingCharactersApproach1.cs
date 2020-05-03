using System.Collections.Generic;

namespace LeetCode.Solutions.LongestSubstringWithoutRepeatingCharacters
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(min(m, n)) where N is the size of the string and M is the size of the charset/alphabet.
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