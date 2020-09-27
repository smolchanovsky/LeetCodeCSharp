namespace LeetCode.Solutions.BestTimeToBuyAndSellStock
{
	/// <summary>
	/// Description: 
	/// Time complexity: O(n).
	/// Space complexity: O(1).
	/// Runtime: 96 ms, faster than 72.00% of C# online submissions for Best Time to Buy and Sell Stock.
	/// Memory Usage: 25.5 MB, less than 5.97% of C# online submissions for Best Time to Buy and Sell Stock.
	/// </summary>
	public class BestTimeToBuyAndSellStockApproach1 : IBestTimeToBuyAndSellStock
	{
		public int GetMaxProfit(int[] prices)
		{
			if (prices.Length == 0)
				return 0;
			
			var minPrice = prices[0];
			var maxProfit = 0;
			
			foreach (var price in prices)
			{
				if (minPrice > price)
					minPrice = price;
				
				var profit = price - minPrice;
				if (maxProfit < profit)
					maxProfit = profit;
			}

			return maxProfit;
		}
	}
}