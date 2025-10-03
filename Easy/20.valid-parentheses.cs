/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(')');
                continue;
            }
            if (s[i] == '{')
            {
                stack.Push('}');
                continue;
            }
            if (s[i] == '[')
            {
                stack.Push(']');
                continue;
            }
            if (stack.Count == 0 || s[i] != stack.Pop())
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
// @lc code=end



