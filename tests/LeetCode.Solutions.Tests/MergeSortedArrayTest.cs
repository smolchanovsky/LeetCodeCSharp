using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.MergeSortedArray;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class MergeSortedArrayTest
    {
        private static IEnumerable testCases = new[]
        {
            new TestCaseData(Array.Empty<int>(), 0, Array.Empty<int>(), 0, Array.Empty<int>())
                .SetName("Empty arrays"),
            new TestCaseData(new[] { 0, 0, 0 }, 0, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3 })
                .SetName("Left array is empty"),
            new TestCaseData(new[] { 1, 2, 3 }, 3, Array.Empty<int>(), 0, new[] { 1, 2, 3 })
                .SetName("Right array it empty"),
            new TestCaseData(new[] { 0, 0, 0, 0 }, 2, new[] { 1, 2 }, 2, new[] { 0, 0, 1, 2 })
                .SetName("Left array consists of zeros"),
            new TestCaseData(new[] { 1, 2, 0, 0 }, 2, new[] { 0, 0 }, 2, new[] { 0, 0, 1, 2 })
                .SetName("Right array consists of zeros"),
            new TestCaseData(new[] { 0, 1, 0, 0 }, 2, new[] { 0, 2 }, 2, new[] { 0, 0, 1, 2 })
                .SetName("Arrays contain zeros"),
            new TestCaseData(new[] { 1, 1, 0, 0 }, 2, new[] { 1, 1 }, 2, new[] { 1, 1, 1, 1 })
                .SetName("Arrays contain duplicates"),
            new TestCaseData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })
                .SetName("Array without duplicates"),
            new TestCaseData(new[] { -2, -1, 3, 0, 0, 0 }, 3, new[] { -2, 5, 6 }, 3, new[] { -2, -2, -1, 3, 5, 6 })
                .SetName("Array with negative numbers"),
            new TestCaseData(new[] { int.MinValue, int.MinValue, -1, 0, 0, 0 }, 3, new[] { -2, 2, int.MaxValue }, 3, new[] { int.MinValue, int.MinValue, -2, -1, 2, int.MaxValue })
                .SetName("Array with min and max numbers")
        };

        private IMergeSortedArray approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new MergeSortedArrayApproach1();
        }

        [TestCaseSource(nameof(testCases))]
        public void Approach1_Merge(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
        {
            approach1.Merge(nums1, m, nums2, n);

            nums1.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}
