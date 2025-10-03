/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, mid;
        while (right >= left)
        {
            mid = (right + left) / 2;
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return left;
    }
}
// @lc code=end

