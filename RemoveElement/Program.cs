using System;

int[] nums;
int val;

nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
val = 2;

Console.WriteLine(RemoveElement(nums, val));

int RemoveElement(int[] nums, int val)
{
    int i = 0;
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != val)
        {
            nums[i] = nums[j];
            i++;
        }
    }
    return i;
}