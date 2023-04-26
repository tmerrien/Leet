using System;

namespace RemoveDuplicates;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
        Console.WriteLine(RemoveDuplicates(nums));
    }

    public static int RemoveDuplicates(int[] nums)
    {
        List<int> finalNum = new List<int>();
        foreach (int i in nums)
        {
            if (!finalNum.Contains(i))
            {
                finalNum.Add(i);
            }
        }
        for (int i = 0; i < finalNum.Count; i++)
        {
            nums[i] = finalNum[i];
        }
        return finalNum.Count;
    }
}