using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.ImplementStrStr;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class ImplementStrStrTest
    {
        private static IEnumerable testCases = new[] { new TestCaseData().SetName("") };

        private IImplementStrStr approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new ImplementStrStrApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_StrStr(string haystack, string needle, int expectedResult)
        {
            var actualResult = approach1.StrStr(haystack, needle);

            actualResult.Should().Be(expectedResult);
        }
    }
}
