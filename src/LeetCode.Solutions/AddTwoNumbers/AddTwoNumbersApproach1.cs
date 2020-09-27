using LeetCode.Helpers;

namespace LeetCode.Solutions.AddTwoNumbers
{
	/// <summary>
	/// Description: Iterative algorithm.
	/// Time complexity: O(max(n, m)) where n and m represents the length of left and right respectively.
	/// Space complexity: O(max(n, m)).
	/// Runtime: 104 ms, faster than 88.80% of C# online submissions for Add Two Numbers.
	/// Memory Usage: 28.3 MB, less than 5.04% of C# online submissions for Add Two Numbers.
	/// </summary>
	public class AddTwoNumbersApproach1 : IAddTwoNumbers
	{
		public ListNode Add(ListNode left, ListNode right)
		{
			var root = new ListNode();
			var currentResult = root;
			ListNode? currentLeft = left;
			ListNode? currentRight = right;
			var carry = 0;

			while (currentLeft != null || currentRight != null || carry != 0)
			{
				var sum = (currentLeft?.Value ?? 0) + (currentRight?.Value ?? 0) + carry;

				currentResult.Next = new ListNode(sum % 10);
				currentResult = currentResult.Next;
				currentLeft = currentLeft?.Next;
				currentRight = currentRight?.Next;
				carry = sum / 10;
			}

			return root.Next!;
		}
	}
}