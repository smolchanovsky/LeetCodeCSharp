namespace LeetCode.Solutions.NumberOfIslands
{
	/// <summary>
	/// Recursive algorithm.
	/// TTime complexity: O(N).
	/// Space complexity: O(1).
	/// </summary>
	public class NumberOfIslandsApproach1 : INumberOfIslands
	{
		public int Get(char[][] grid)
		{
			var numberOfIslands = 0;
			for (var y = 0; y < grid.Length; y++)
			{
				for (var x = 0; x < grid[y].Length; x++)
				{
					if (grid[y][x] == '0')
						continue;
					
					DFS(x, y, grid);
					++numberOfIslands;
				}
			}

			return numberOfIslands;
		}

		private void DFS(int x, int y, char[][] grid)
		{
			if (y == -1 || y == grid.Length)
				return;
			if (x == -1 || x == grid[y].Length)
				return;
			if (grid[y][x] == '0')
				return;

			grid[y][x] = '0';
			
			DFS(x - 1, y, grid);
			DFS(x + 1, y, grid);
			DFS(x, y - 1, grid);
			DFS(x, y + 1, grid);
		}
	}
}