/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1, j = n - 1, r = n + m - 1;
        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[r] = nums1[i];
                i--;
            }
            else
            {
                nums1[r] = nums2[j];
                j--;
            }
            r--;
        }
    }
}
// @lc code=end

