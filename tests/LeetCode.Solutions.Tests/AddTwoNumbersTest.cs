using System.Collections;
using FluentAssertions;
using LeetCode.Helpers;
using LeetCode.Solutions.AddTwoNumbers;
using NUnit.Framework;

namespace LeetCode.Solutions.Tests
{
	[TestFixture]
	public class AddTwoNumbersTest
	{
		private static IEnumerable testCases = new[]
		{
			new TestCaseData(
					new LinkedList(new[] {0}).First, 
					new LinkedList(new[] {0}).First,
					new LinkedList(new[] {0}).First)
				.SetName("Zero numbers"),
			new TestCaseData(
					new LinkedList(new[] {2, 4, 3}).First, 
					new LinkedList(new[] {5, 6, 4}).First,
					new LinkedList(new[] {7, 0, 8}).First)
				.SetName("Same length numbers"),
			new TestCaseData(
					new LinkedList(new[] {2, 4, 3}).First, 
					new LinkedList(new[] {5, 6}).First,
					new LinkedList(new[] {7, 0, 4}).First)
				.SetName("Left number is longer"),
			new TestCaseData(
					new LinkedList(new[] {2, 4}).First, 
					new LinkedList(new[] {5, 6, 4}).First,
					new LinkedList(new[] {7, 0, 5}).First)
				.SetName("Right number is longer"),
			new TestCaseData(
					new LinkedList(new[] {2, 4, 9, 9, 9, 9, 9}).First, 
					new LinkedList(new[] {5, 6}).First,
					new LinkedList(new[] {7, 0, 0, 0, 0, 0, 0, 1}).First)
				.SetName("Many carry (left number is longer)"),
			new TestCaseData(
					new LinkedList(new[] {2, 4}).First, 
					new LinkedList(new[] {5, 6, 9, 9, 9, 9, 9}).First,
					new LinkedList(new[] {7, 0, 0, 0, 0, 0, 0, 1}).First)
				.SetName("Many carry (right number is longer)"),
		};

		private IAddTwoNumbers approach1;
		
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			approach1 = new AddTwoNumbersApproach1();
		}

		[TestCaseSource(nameof(testCases))]
		public void Approach1_Add(ListNode left, ListNode right, ListNode expectedResult)
		{
			var actualResult = approach1.Add(left, right);

			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}