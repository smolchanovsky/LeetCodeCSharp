namespace LeetCode.Solutions.BestTimeToBuyAndSellStock
{
	/// <summary>
	/// Time complexity: O(n).
	/// Space complexity: O(1).
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