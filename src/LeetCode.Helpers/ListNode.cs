namespace LeetCode.Helpers
{
	public class ListNode 
	{
		public int Value { get; }
		public ListNode? Next { get; set; }

		public ListNode(int value = 0, ListNode? next = null) 
		{
			Value = value;
			Next = next;
		}
	}
}
