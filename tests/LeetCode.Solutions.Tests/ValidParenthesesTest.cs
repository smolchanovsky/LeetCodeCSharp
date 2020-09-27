using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.ValidParentheses;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class ValidParenthesesTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData("", true)
				.SetName("Empty string"),
			new TestCaseData("(", false)
				.SetName("Single opening bracket"),
			new TestCaseData("((((((", false)
				.SetName("Many opening bracket"),
			new TestCaseData("()", true)
				.SetName("One pair of same type brackets"),
			new TestCaseData("(]", false)
				.SetName("One pair of different type brackets 1"),
			new TestCaseData("(}", false)
				.SetName("One pair of different type brackets 2"),
			new TestCaseData("{]", false)
				.SetName("One pair of different type brackets 3"),
			new TestCaseData("([{}])", true)
				.SetName("One pair of all types brackets"),	
			new TestCaseData("(){}[]", true)
				.SetName("Expression with not nested bracket pairs"),
			new TestCaseData("((([{}]]))", false)
				.SetName("Invalid expression with different types of brackets"),
			new TestCaseData("()[({})]{}", true)
				.SetName("Valid expression with different types of brackets")
		};
		
		private IValidParentheses approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new ValidParenthesesApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_IsValid(string str, bool expectedResult)
		{
			var actualResult = approach1.IsValid(str);
			
			actualResult.Should().Be(expectedResult);
		}
	}
}
