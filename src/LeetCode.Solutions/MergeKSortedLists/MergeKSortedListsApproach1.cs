using System.Linq;
using LeetCode.Helpers;

namespace LeetCode.Solutions.MergeKSortedLists
{
	/// <summary>
	/// Description: 
	/// Iterative algorithm.
	/// Time complexity: O(n * log k) where K is the number of linked lists.
	/// Space complexity: O(1).
	/// Runtime: 112 ms, faster than 84.34% of C# online submissions for Merge k Sorted Lists.
	/// Memory Usage: 29.9 MB, less than 12.36% of C# online submissions for Merge k Sorted Lists.
	/// </summary>
	public class MergeKSortedListsApproach1 : IMergeKSortedLists
	{
		public ListNode Merge(ListNode[] lists)
		{
			var step = 1;
			while (step < lists.Length)
			{
				for (var i = 0; i + step < lists.Length; i += step * 2)
				{
					lists[i] = Merge(lists[i], lists[i + step]);
				}

				step *= 2;
			}

			return lists.FirstOrDefault();
		}

		private ListNode Merge(ListNode first, ListNode second)
		{
			var root = new ListNode();
			var currentResult = root;
			ListNode? currentFirst = first;
			ListNode? currentSecond = second;

			while (currentFirst != null || currentSecond != null)
			{
				if (currentFirst == null || currentFirst.Value > currentSecond?.Value)
				{
					currentResult.Next = currentSecond!;
					currentResult = currentResult.Next;
					currentSecond = currentSecond!.Next;
					continue;
				}

				if (currentSecond == null || currentFirst?.Value <= currentSecond.Value)
				{
					currentResult.Next = currentFirst!;
					currentResult = currentResult.Next;
					currentFirst = currentFirst!.Next;
					continue;
				}
			}

			return root.Next!;
		}
	}
}
