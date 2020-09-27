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
            new TestCaseData()
                .SetName("")
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

            nums1.Should().BeEquivalentTo(expectedResult);
        }
    }
}
