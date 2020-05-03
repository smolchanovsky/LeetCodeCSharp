using System;
using System.Collections;
using FluentAssertions;
using LeetCode.Solutions.ReverseInteger;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class ReverseIntegerTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(1, 1)
				.SetName("One-digit number"),
			new TestCaseData(-1, -1)
				.SetName("One-digit negative number"),
			new TestCaseData(123, 321)
				.SetName("Positive number"),
			new TestCaseData(-123, -321)
				.SetName("Negative number"),
			new TestCaseData(120, 21)
				.SetName("Number is multiple of ten"),
			new TestCaseData(-120, -21)
				.SetName("Negative number is a multiple of ten"),
			new TestCaseData(int.MinValue, 0)
				.SetName("Int32 min value"),
			new TestCaseData(int.MaxValue, 0)
				.SetName("Int32 max value"),
		};
		
		private IReverseInteger approach1;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			approach1 = new ReverseIntegerApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Reverse(int number, int expectedResult)
		{
			var actualResult = approach1.Reverse(number);
			
			actualResult.Should().Be(expectedResult);
		}
	}
}