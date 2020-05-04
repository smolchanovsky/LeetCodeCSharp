using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.ValidAnagram;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class ValidAnagramTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData("", "", true)
				.SetName("Empty strings"),
			new TestCaseData("", "abc", false)
				.SetName("First is empty string"),
			new TestCaseData("abc", "", false)
				.SetName("Second is empty strings"),
			new TestCaseData("a", "a", true)
				.SetName("Same one-char strings"),
			new TestCaseData("an", "na", true)
				.SetName("Two-char anagram"),
			new TestCaseData("anagram", "nagaram", true)
				.SetName("Long anagram"),
			new TestCaseData("anagram", "margana", true)
				.SetName("Reversed string"),
			new TestCaseData("abc", "dcba", false)
				.SetName("Not anagram"),
			new TestCaseData("abc", "def", false)
				.SetName("Strings without union")
		};
		
		private IValidAnagram approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new ValidAnagramApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_IsAnagram(string first, string second, bool expectedResult)
		{
			var actualResult = approach1.IsAnagram(first, second);
			
			actualResult.Should().Be(expectedResult);
		}
	}
}