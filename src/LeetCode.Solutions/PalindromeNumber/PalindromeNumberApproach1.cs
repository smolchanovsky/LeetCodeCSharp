namespace LeetCode.Solutions.PalindromeNumber
{
	/// <summary>
	/// 
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