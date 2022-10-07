namespace _1480._Running_Sum_of_1d_Array;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int sum = nums.Sum();
        int prev = nums[nums.Length - 1];
        nums[nums.Length - 1] = sum;

        for (int i = nums.Length - 2; i >= 1; i--)
        {
            int temp = nums[i + 1] - prev;
            prev = nums[i];
            nums[i] = temp;
        }
        return nums;
    }
}