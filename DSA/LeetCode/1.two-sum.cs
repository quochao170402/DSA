/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        var dic = new Dictionary<int, int>();
        var length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            dic.TryAdd(nums[i], i);

            var sub = target - nums[i];
            if (dic.TryGetValue(sub, out var index))
            {
                if (i == index) continue;
                return [i, index];
            }
        }

        // for (int i = 0; i < length; i++)
        // {
        //     var sub = target - nums[i];
        //     if (dic.TryGetValue(sub, out var index))
        //     {
        //         if (i == index) continue;
        //         return [i, index];
        //     }
        // }

        return result;
    }


}
// @lc code=end

