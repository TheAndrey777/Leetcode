namespace _189._Rotate_Array;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Array.Reverse(nums, 0, nums.Length);
        Array.Reverse(nums, k, nums.Length - (k + 1) + 1);
        Array.Reverse(nums, 0, k);
    }
}
