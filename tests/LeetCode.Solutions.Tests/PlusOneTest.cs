using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.PlusOne;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class PlusOneTest
    {
        private static IEnumerable testCases = new[] { new TestCaseData().SetName("") };

        private IPlusOne approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new PlusOneApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_PlusOne(int[] digits, int[] expectedResult)
        {
            var actualResult = approach1.PlusOne();

            actualResult.Should().Be(expectedResult);
        }
    }
}
