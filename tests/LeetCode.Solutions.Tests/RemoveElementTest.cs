using System;
using System.Collections;
using System.Linq;
using LeetCode.Solutions.RemoveElement;
using NUnit.Framework;
using FluentAssertions;
using FluentAssertions.Execution;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class RemoveElementTest
    {
        private static IEnumerable testCases = new[]
        {
            new TestCaseData(Array.Empty<int>(), 1, Array.Empty<int>(), 0)
                .SetName("Empty array"),
            new TestCaseData(new[] { 1 }, 1, Array.Empty<int>(), 0)
                .SetName("Single item array: remove existing item"),
            new TestCaseData(new[] { 1 }, 0, new[] { 1 }, 1)
                .SetName("Single item array: remove not existing item"),
            new TestCaseData(new[] { 3, 1, 2 }, 2, new[] { 3, 1 }, 2)
                .SetName("Array with multiple items: remove existing item"),
            new TestCaseData(new[] { 1, 1, 3, 2, 2 }, 10, new[] { 1, 1, 3, 2, 2 }, 5)
                .SetName("Array with multiple items: remove not existing item"),
            new TestCaseData(new[] { 1, 2, 1, 2, 3 }, 1, new[] { 2, 2, 3 }, 3)
                .SetName("Array with duplicates"),
            new TestCaseData(new[] { 1, 1, 2, 2, 3 }, 1, new[] { 2, 2, 3 }, 3)
                .SetName("Sorted array"),
            new TestCaseData(new[] { 2, -1, -1, 0, 0, 3 }, -1, new[] { 2, 0, 0, 3 }, 4)
                .SetName("Array with negative numbers"),
            new TestCaseData(new[] { 12321, 1322, 2454, 23222, 30000 }, 2454, new[] { 12321, 1322, 23222, 30000  }, 4)
                .SetName("Array with big numbers"),
            new TestCaseData(new[] { 12321, int.MaxValue, 2454, 23222, 30000 }, int.MaxValue, new[] { 12321, 2454, 23222, 30000  }, 4)
                .SetName("Array with int max value"),
            new TestCaseData(new[] { 12321, int.MinValue, 2454, 23222, 30000 }, int.MinValue, new[] { 12321, 2454, 23222, 30000  }, 4)
                .SetName("Array with int min value"),
        };

        private IRemoveElement approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new RemoveElementApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_RemoveElement(int[] nums, int val, int[] expectedNums, int expectedLength)
        {
            var actualLength = approach1.RemoveElement(nums, val);

            using (new AssertionScope())
            {
                actualLength.Should().Be(expectedLength);
                nums.Take(actualLength).Should().BeEquivalentTo(expectedNums);   
            }
        }
    }
}
