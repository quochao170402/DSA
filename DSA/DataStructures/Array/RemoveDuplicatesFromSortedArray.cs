namespace DSA.DataStructures.Array;

public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int index = 0;
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (dic.ContainsKey(current))
            {
                dic[current] = dic[current]++;
            }
            else
            {
                nums[index++] = current;
                dic[current] = 1;
            }
        }
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
        return index;
    }

    public void Solution()
    {
        int[] nums = [1, 1, 2];
        Console.WriteLine($"result: {RemoveDuplicates(nums)}");
    }
}
// [1,1,2,2,3,3,3,3]
// 1-2,2-2,3-4
//