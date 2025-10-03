/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var cur = nums[i];
            var x = target - cur;
            if (dict.TryGetValue(x, out int j))
            {
                return [j, i];
            }
            else dict.TryAdd(cur, i);
        }
        return [];
    }
}
// @lc code=end

