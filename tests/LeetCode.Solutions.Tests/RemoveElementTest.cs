using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.RemoveElement;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class RemoveElementTest
    {
        private static IEnumerable testCases = new[] { new TestCaseData().SetName("") };

        private IRemoveElement approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new RemoveElementApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_RemoveElement(int[] nums, int val, int expectedResult)
        {
            var actualResult = approach1.RemoveElement(nums, val);

            actualResult.Should().Be(expectedResult);
        }
    }
}
