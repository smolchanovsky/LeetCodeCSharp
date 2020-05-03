using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.PalindromeNumber;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class PalindromeNumberTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(1, true)
				.SetName("One-digit number"),
			new TestCaseData(-1, false)
				.SetName("One-digit negative number"),
			new TestCaseData(11, true)
				.SetName("Two-digit palindrome number"),
			new TestCaseData(121, true)
				.SetName("Short palindrome number with odd number of digits"),
			new TestCaseData(12345154321, true)
				.SetName("Long palindrome number with odd number of digits"),
			new TestCaseData(1221, true)
				.SetName("Short palindrome number with even number of digits"),
			new TestCaseData(1234554321, true)
				.SetName("Long palindrome number with even number of digits"),
			new TestCaseData(123, false)
				.SetName("Positive number with unique digits"),
			new TestCaseData(-123, false)
				.SetName("Negative number with unique digits"),
			new TestCaseData(120, false)
				.SetName("Number is multiple of ten"),
			new TestCaseData(-120, false)
				.SetName("Negative number is a multiple of ten"),
			new TestCaseData(int.MinValue, false)
				.SetName("Int32 min value"),
			new TestCaseData(int.MaxValue, false)
				.SetName("Int32 max value"),
		};
		
		private IPalindromeNumber approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new PalindromeNumberApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_IsPalindrome(int number, bool expectedResult)
		{
			var actualResult = approach1.IsPalindrome(number);
			
			actualResult.Should().Be(expectedResult);
		}
	}
}