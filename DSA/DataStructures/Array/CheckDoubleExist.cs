namespace DSA.DataStructures.Array;

public class CheckDoubleExist
{
    public bool CheckIfExist(int[] arr)
    {
        var temp = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            temp.TryAdd(arr[i], i);
        }

        for (var i = 0; i < arr.Length; i++)
        {
            var current = arr[i];
            if (temp.TryGetValue(current * 2, out var index))
            {
                if(index == i)
                    continue;

                var value = arr[index];
                if (value == current * 2)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Solution()
    {
        int[] arr = [-2, 0, 10, -19, 4, 6, -8];
        Console.WriteLine(CheckIfExist(arr));
    }
}