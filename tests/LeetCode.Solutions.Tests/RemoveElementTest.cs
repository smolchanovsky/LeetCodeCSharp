using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Helpers;
using LeetCode.Solutions.ImplementQueueUsingStacks;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Solutions.Tests
{
    [TestFixture]
    public class ImplementQueueUsingStacksTest
    {
        private IImplementQueueUsingStacks approach1;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            approach1 = new ImplementQueueUsingStacksApproach1();
        }

        [Test]
        public void Approach1(Action<IImplementQueueUsingStacks> act)
        {
        }
    }
}
