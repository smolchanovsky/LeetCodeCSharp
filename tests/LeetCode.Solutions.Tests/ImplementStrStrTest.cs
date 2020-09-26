using System.Collections;
using LeetCode.Solutions.ImplementStrStr;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class ImplementStrStrTest
    {
        private static IEnumerable testCases = new[]
        {
            new TestCaseData("hello", "e", 1)
                .SetName("Needle with single letter"),
            new TestCaseData("hello", "lo", 3)
                .SetName("Needle with two letter"),
            new TestCaseData("hello", "ll", 2)
                .SetName("Needle with two repeating letters"),
            new TestCaseData("Hay1stack", "1s", 3)
                .SetName("Needle with digit"),
            new TestCaseData("Hay123stack", "123", 3)
                .SetName("Needle with number"),
            new TestCaseData("HayStack", "St", 3)
                .SetName("Needle with upper chars"),
            new TestCaseData("Hay$tack", "$t", 3)
                .SetName("Needle with special symbol"),
            new TestCaseData("hello", "hello", 0)
                .SetName("Needle equals haystack"),
            new TestCaseData("hello", "l", 2)
                .SetName("Haystack with two needle"),
            new TestCaseData("hello", "", 0)
                .SetName("Needle is empty"),
            new TestCaseData("", "", 0)
                .SetName("Needle and haystack are empty"),
            new TestCaseData("Haystack", "bba", -1)
                .SetName("No needle in haystack"),
            new TestCaseData("aaaaa", "bba", -1)
                .SetName("No needle in haystack with repeating letters"),
            new TestCaseData("hello", "hello world", -1)
                .SetName("Needle longer than haystack"),
            new TestCaseData("", "hello", -1)
                .SetName("Haystack is empty")
        };

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
