namespace LeetCode.Solutions.PalindromeNumber
{
	/// <summary>
	/// Time Complexity: O(log(x)). There are roughly log10(x) digits in x.
	/// Space Complexity: O(1).
	/// </summary>
	public class PalindromeNumberApproach1 : IPalindromeNumber
	{
		public bool IsPalindrome(int number)
		{
			var left = 0;
			var right = number;

			while (left < right)
			{
				left = left * 10 + right % 10;
				right /= 10;
			}

			return left == right || left / 10 == right;
		}
	}
}