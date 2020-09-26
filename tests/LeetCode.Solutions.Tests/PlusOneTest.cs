using System.Collections;
using LeetCode.Solutions.PlusOne;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class PlusOneTest
    {
        private static IEnumerable testCases = new[]
        {
            new TestCaseData(new[] { 0 }, new[] { 1 })
                .SetName("Zero"),
            new TestCaseData(new[] { 9 }, new[] { 1, 0 })
                .SetName("Addition with carry: one digit number"),
            new TestCaseData(new[] { 9, 9 }, new[] { 1, 0, 0 })
                .SetName("Addition with carry: two digit number"),
            new TestCaseData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })
                .SetName("Multiple digits number"),
            new TestCaseData(new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 })
                .SetName("Addition with carry: multiple digits number"),
            new TestCaseData(new[] { 1, 0, 0, 0 }, new[] { 1, 0, 0, 1 })
                .SetName("Round number"),
            new TestCaseData(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })
                .SetName("Big multiple digits number"),
        };

        private IPlusOne approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new PlusOneApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_PlusOne(int[] digits, int[] expectedResult)
        {
            var actualResult = approach1.PlusOne(digits);

            actualResult.Should().BeEquivalentTo(expectedResult);
        }
    }
}
