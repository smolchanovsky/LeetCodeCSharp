using System.Collections.Generic;

namespace LeetCode.Solutions.ValidParentheses
{
	/// <summary>
	/// Description: 
	/// Time complexity : O(n).
	/// Space complexity : O(n).
	/// Runtime: 76 ms, faster than 65.02% of C# online submissions for Valid Parentheses.
	/// Memory Usage: 22.3 MB, less than 11.50% of C# online submissions for Valid Parentheses.
	/// </summary>
	public class ValidParenthesesApproach1 : IValidParentheses
	{
		public bool IsValid(string str)
		{
			var stack = new Stack<char>();

			foreach (var character in str)
			{
				if (IsOpeningBracket(character))
				{
					stack.Push(character);
					continue;
				}
				
				stack.TryPop(out var lastOpeningBracket);
					if (lastOpeningBracket != TryGetOpeningBracket(character))
						return false;
			}

			return stack.Count == 0;
		}

		private bool IsOpeningBracket(char character)
		{
			return TryGetOpeningBracket(character) == null;
		}
		
		private char? TryGetOpeningBracket(char character)
		{
			return character switch
			{
				')' => '(', 
				']' => '[', 
				'}' => '{',
				_ => null
			};
		}
	}
}
