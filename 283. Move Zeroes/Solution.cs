namespace _283._Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int count = nums.Count(n => n == 0);
        for (int i = 1; i <= nums.Length - 1; i++)
        {
            int a = i;
            while (a > 0 && nums[a - 1] == 0)
            {
                int temp = nums[a];
                nums[a - 1] = temp;
                nums[a] = 0;
                a--;
            }
        }
    }
}
