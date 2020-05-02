using LeetCode.Helpers;

namespace LeetCode.Solutions.AddTwoNumbers
{
	/// <summary>
	/// Iterative algorithm.
	/// Time complexity: O(max(N,M)) where N and M represents the length of left and right respectively.
	/// Space complexity: O(max(N,M)).
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