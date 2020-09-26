namespace LeetCode.Solutions.ImplementStrStr
{
    /// <summary>
	/// Time complexity: O(n * m) where n is haystack length and m is needle length.
	/// Space complexity: O(m).
	/// Runtime: 72 ms, faster than 91.05% of C# online submissions for Implement strStr().
	/// Memory Usage: 23 MB, less than 21.18% of C# online submissions for Implement strStr().
	/// </summary>
    public class ImplementStrStrApproach1 : IImplementStrStr
    {
        public int StrStr(string haystack, string needle)
		{
			for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
			{
				var needleCandidate = haystack[i..(i + needle.Length)];
				if (needleCandidate == needle)
					return i;
			}

			return -1;
		}
    }
}
