using System;

namespace DSA.DataStructures.Array;

public class FindAllNumbersDisappearedArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var dic = new Dictionary<int, int>();
        int length = nums.Length;
        for (int i = 1; i <= length; i++)
        {
            dic[i] = 0;
        }

        for (int i = 0; i < length; i++)
        {
            dic[nums[i]] = dic[nums[i]] + 1;
        }

        var result = new List<int>();
        foreach (var (key, value) in dic)
        {
            if (value == 0)
            {
                result.Add(key);
            }
        }

        return result;
    }

    public IList<int> Improve(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var result = new List<int>();
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }

    public void Solution()
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1, 1, 1, 2, 10];
        var result = Improve(nums);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }
}
