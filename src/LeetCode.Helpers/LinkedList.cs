using System;
using System.Collections.Generic;

namespace LeetCode.Helpers
{
	public class LinkedList 
	{
		public ListNode? First { get; }

		public LinkedList(ICollection<int> collection) 
		{
			if (collection == null)
				throw new ArgumentNullException(nameof(collection));

			ListNode? current = null;
			foreach (var value in collection)
			{
				if (current == null)
					current = First = new ListNode(value);
				else 
					current = current.Next = new ListNode(value);
			}
		}
	}
}