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
            foreach (var str in strs)
            {
                if (i > str.Length - 1 || strs[0][i] != str[i])
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

