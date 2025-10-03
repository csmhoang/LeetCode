/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        var charArray = x.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray) == x.ToString();
    }

}
// @lc code=end

