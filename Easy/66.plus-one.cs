/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += 1;
            if (digits[i] % 10 == 0)
            {
                digits[i] = 0;
                continue;
            }
            return digits;
        }
        return [1, .. digits];
    }
}
// @lc code=end

