using System.Collections;
using LeetCode.Solutions.SingleNumber;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class SingleNumberTest
    {
        private static IEnumerable testCases = new[]
        {
            new TestCaseData(new[] { 1 }, 1)
                .SetName("Array with single item"),
            new TestCaseData(new[] { 2, 2, 1 }, 1)
                .SetName("Array with one repeating item"),
            new TestCaseData(new[] { 4, 1, 2, 1, 2 }, 4)
                .SetName("Array with multiple repeating items"),
            new TestCaseData(new[] { 4, -1, 2, -1, 2 }, 4)
                .SetName("Array with multiple repeating negative items"),
            new TestCaseData(new[] { 3, 3, -4, 2, 2 }, -4)
                .SetName("Negative non-repeating item"),
            new TestCaseData(new[] { 43894329, 1493049, 23918343, 1493049, 23918343 }, 43894329)
                .SetName("Array with big numbers")
        };

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
