/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k])
            {
                nums[++k] = nums[i];
            }
        }
        return k + 1;
    }
}
// @lc code=end

