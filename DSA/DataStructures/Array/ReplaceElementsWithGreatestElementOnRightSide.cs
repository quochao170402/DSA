using System;

namespace DSA.DataStructures.Array;

public class ReplaceElementsWithGreatestElementOnRightSide
{
    public int[] ReplaceElements(int[] arr)
    {
        // var length = arr.Length;
        // int greatest = arr[1];
        // for (int i = 0; i < length; i++)
        // {
        //     if (i == arr.Length - 1)
        //     {
        //         arr[i] = -1;
        //         continue;
        //     }

        //     int max = arr[i + 1];
        //     for (int j = i + 1; j < length; j++)
        //     {
        //         if (arr[j] > max)
        //         {
        //             max = arr[j];
        //         }
        //     }

        //     arr[i] = max;
        // }
        // return arr;

        int greatest = -1;
        for (int i = arr.Length - 1; i >= 0; --i)
        {
            int current = arr[i];
            arr[i] = greatest;
            greatest = Math.Max(greatest, current);
        }
        return arr;
    }

    public void Solution()
    {
        int[] arr = [17, 18, 18, 5, 4, 6, 1];
        ReplaceElements(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Wri
        }
    }
}
