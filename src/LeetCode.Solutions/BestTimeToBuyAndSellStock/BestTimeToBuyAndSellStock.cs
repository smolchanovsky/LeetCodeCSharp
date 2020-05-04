namespace LeetCode.Solutions.BestTimeToBuyAndSellStock
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/">Best Time to Buy and Sell Stock</see>
	/// Say you have an array for which the i-th element is the price of a given stock on day i.
	/// If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock),
	/// design an algorithm to find the maximum profit.
	/// Note that you cannot sell a stock before you buy one.
	/// </summary>
	public interface IBestTimeToBuyAndSellStock
	{
		int GetMaxProfit(int[] prices);
	}
}