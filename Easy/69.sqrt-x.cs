/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */

// @lc code=start
public class Solution
{
    public int MySqrt(int x)
    {
        double sprev = 3e9;
        double scur = sprev;
        do
        {
            sprev = scur;
            scur = 0.5 * (sprev + x / sprev);
        } while (sprev - scur > 1);
        return (int)scur;
    }
}
// @lc code=end

