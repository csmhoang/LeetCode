/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }
        string prefixString = string.Empty;
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length - 1 || strs[0][i] != strs[j][i])
                {
                    return prefixString;
                }
            }
            prefixString += strs[0][i];
        }
        return prefixString;
    }
}
// @lc code=end

