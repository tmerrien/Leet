// Input
int[] nums;
int target;

// Test case 1 
nums = new int[] { 1, 3, 5, 6 };
target = 5;
Console.WriteLine(SearchInsert(nums, target));

// Test case 2
nums = new int[] { 1, 3, 5, 6 };
target = 2;
Console.WriteLine(SearchInsert(nums, target));

// Test case 3
nums = new int[] { 1, 3, 5, 6 };
target = 7;
Console.WriteLine(SearchInsert(nums, target));

// Algorithm
int SearchInsert(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;
    while (left <= right)
    {
        
        int mid = left + (right - left) / 2;
        switch (nums[mid].CompareTo(target))
        {
            case 0:
                return mid;
            case -1:
                left = mid + 1;
                break;
            case 1:
                right = mid - 1;
                break;
        }
    }
    return left;
}