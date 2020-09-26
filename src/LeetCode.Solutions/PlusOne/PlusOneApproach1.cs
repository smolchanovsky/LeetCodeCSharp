using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.PlusOne
{
    /// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(n).
	/// Runtime: Runtime: 220 ms, faster than 99.82% of C# online submissions for Plus One.
	/// Memory Usage: 30.6 MB, less than 5.01% of C# online submissions for Plus One.
	/// </summary>
    public class PlusOneApproach1 : IPlusOne
    {
        public int[] PlusOne(int[] digits)
		{
			return ReverseAndPlusOne(digits).Reverse().ToArray();
		}

		private static IEnumerable<int> ReverseAndPlusOne(IReadOnlyList<int> digits)
		{
			var isRequiredAddition = true;
			for (var i = digits.Count - 1; i >= 0; i--)
			{
				if (digits[i] < 9 && isRequiredAddition)
				{
					isRequiredAddition = false;
					yield return digits[i] + 1;	
				}
				else if (isRequiredAddition)
					yield return 0;
				else
					yield return digits[i];
			}
			
			if (isRequiredAddition)
				yield return 1;
		}
    }
}