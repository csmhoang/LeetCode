/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int n = haystack.Length;
        int m = needle.Length;
        if (n < m)
        {
            return -1;
        }
        int i = 0, j = 0;
        while (i < n)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
                if (j == m)
                {
                    return i - m;   
                }
                continue;
            }
            i = i - j + 1;
            j = 0;
        }
        return -1;
    }
}
// @lc code=end

