namespace _217._Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        return !(numSet.Count == nums.Length);
    }
}
