using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.LongestSubstringWithoutRepeatingCharacters;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class LongestSubstringWithoutRepeatingCharactersTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData("", 0)
				.SetName("Empty string"),
			new TestCaseData("bbbbb", 1)
				.SetName("One repeating character"),
			new TestCaseData("abcdefghij", 10)
				.SetName("All characters are unique"),
			new TestCaseData("abcabcabc", 3)
				.SetName("Repeating set of three characters"),
			new TestCaseData("pwwkew", 3)
				.SetName("Subsequence of four unique characters"),
			new TestCaseData("dvadf", 4)
				.SetName("Items between same characters")
		};
		
		private ILongestSubstringWithoutRepeatingCharacters approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new LongestSubstringWithoutRepeatingCharactersApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_GetLength(string str, int expectedResult)
		{
			var actualResult = approach1.GetLength(str);
			
			actualResult.Should().Be(expectedResult);
		}
	}
}
