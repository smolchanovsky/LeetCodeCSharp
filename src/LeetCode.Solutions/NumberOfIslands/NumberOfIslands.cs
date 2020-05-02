namespace LeetCode.Solutions.NumberOfIslands
{
	/// <summary>
	/// <see href="https://leetcode.com/problems/number-of-islands/">Number of Islands</see>
	/// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded
	/// by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges
	/// of the grid are all surrounded by water.
	/// </summary>
	public interface INumberOfIslands
	{
		int Get(char[][] grid);
	}
}