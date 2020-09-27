namespace LeetCode.Solutions.ReverseInteger
{
	/// <summary>
	/// Description: 
	/// Time Complexity: O(log(x)). There are roughly log10(x) digits in x.
	/// Space Complexity: O(1).
	/// Runtime: 40 ms, faster than 89.69% of C# online submissions for Reverse Integer.
	/// Memory Usage: 15.5 MB, less than 9.96% of C# online submissions for Reverse Integer.
	/// </summary>
	public class ReverseIntegerApproach1 : IReverseInteger
	{
		private const int intMaxValueLastDigit = 7;
		private const int intMinValueLastDigit = 8;
		
		public int Reverse(int number)
		{
			var result = 0;

			while (number != 0)
			{
				var pop = number % 10;
				if (WillOverflow(result, pop)) 
					return 0;

				number /= 10;
				result = checked(result * 10 + pop);
			}

			return result;
		}

		private static bool WillOverflow(int currentResult, int currentPop)
		{
			if (currentResult > int.MaxValue / 10 || (currentResult == int.MaxValue / 10 && currentPop > intMaxValueLastDigit)) 
				return true;
			if (currentResult < int.MinValue / 10 || (currentResult == int.MinValue / 10 && currentPop < -intMinValueLastDigit)) 
				return true;

			return false;
		}
	}
}
