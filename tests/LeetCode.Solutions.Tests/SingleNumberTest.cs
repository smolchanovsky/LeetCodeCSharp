using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.SingleNumber;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class SingleNumberTest
    {
        private static IEnumerable testCases = new[] { new TestCaseData().SetName("") };

        private ISingleNumber approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new SingleNumberApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_SingleNumber(int[] nums, int expectedResult)
        {
            var actualResult = approach1.SingleNumber(nums);

            actualResult.Should().Be(expectedResult);
        }
    }
}
