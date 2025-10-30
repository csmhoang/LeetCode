// /*
//  * @lc app=leetcode id=67 lang=csharp
//  *
//  * [67] Add Binary
//  */

// // @lc code=start
public class Solution
{
    public string AddBinary(string a, string b)
    {
        int n;
        bool carry = false;
        var result = new Stack<char>();
        if (a.Length > b.Length)
        {
            n = a.Length;
            b = b.PadLeft(n, '0');
        }
        else
        {
            n = b.Length;
            a = a.PadLeft(n, '0');
        }

        for (int i = n - 1; i >= 0; i--)
        {
            if (carry)
            {
                if (a[i] == b[i] && a[i] == '0')
                {
                    result.Push('1');
                    carry = false;
                }
                else if (a[i] != b[i])
                {
                    result.Push('0');
                }
                else if (a[i] == b[i] && a[i] == '1')
                {
                    result.Push('1');
                }
            }
            else
            {
                if (a[i] == b[i] && a[i] == '0')
                {
                    result.Push('0');
                }
                else if (a[i] != b[i])
                {
                    result.Push('1');
                }
                else if (a[i] == b[i] && a[i] == '1')
                {
                    result.Push('0');
                    carry = true;
                }
            }
        }
        if (carry)
        {
            result.Push('1');
        }
        return String.Concat(result);
    }
}
// // @lc code=end

