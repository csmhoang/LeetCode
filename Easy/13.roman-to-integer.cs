/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }
        var dict = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        int sum = 0;
        int last = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int cur = dict[s[i]];
            if (cur < last)
            {
                sum -= cur;
            }
            else
            {
                sum += cur;
            }
            last = cur;
        }
        return sum;
    }
}
// @lc code=end

