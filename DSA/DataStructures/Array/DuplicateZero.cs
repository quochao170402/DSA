using System;

namespace DSA.DataStructures.Array;

public class DuplicateZero
{
    public DuplicateZero()
    {

    }
    public void DuplicateZeros(int[] arr)
    {
        var temp = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                temp.Add(arr[i]);

            }
            else
            {
                temp.Add(0);
                temp.Add(0);
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = temp[i];
        }
    }

}