namespace LeetCode.Solutions.PalindromeNumber
{
	/// <summary>
	/// Description: 
	/// Time Complexity: O(log(x)). There are roughly log10(x) digits in x.
	/// Space Complexity: O(1).
	/// Runtime: 72 ms, faster than 52.99% of C# online submissions for Palindrome Number.
	/// Memory Usage: 16.5 MB, less than 29.41% of C# online submissions for Palindrome Number.
	/// </summary>
	public class PalindromeNumberApproach1 : IPalindromeNumber
	{
		public bool IsPalindrome(int number)
		{
			if(number < 0 || (number != 0 && number % 10 == 0))
				return false;
			
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
