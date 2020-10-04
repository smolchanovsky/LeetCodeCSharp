using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.ImplementQueueUsingStacks
{
    /// <summary>
	/// <see href="https://leetcode.com/problems/implement-queue-using-stacks">ImplementQueueUsingStacks</see>
	/// Implement the following operations of a queue using stacks.
	/// - push(x) -- Push element x to the back of queue.
	/// - pop() -- Removes the element from in front of queue.
	/// - peek() -- Get the front element.
	/// - empty() -- Return whether the queue is empty.
	/// </summary>
    public interface IImplementQueueUsingStacks
	{
		void Push(int x);
		int Pop();
		int Peek();
		bool Empty();
	}
}
