using System.Linq;

namespace LeetCode.Solutions.ValidAnagram
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// </summary>
	public class ValidAnagramApproach1 : IValidAnagram
	{
		public bool IsAnagram(string first, string second)
		{
			if (first.Length != second.Length)
				return false;
			
			var charCounter = new int['z' - 'a' + 1];

			for (var i = 0; i < first.Length; i++)
			{
				var firstCharIndex = 'z' - first[i];
				++charCounter[firstCharIndex];
				
				var secondCharIndex = 'z' - second[i];
				--charCounter[secondCharIndex];
			}

			return charCounter.All(x => x == 0);
		}
	}
}