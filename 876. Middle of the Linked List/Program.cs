namespace _876._Middle_of_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            ListNode d = new ListNode().Create(nums);
            ListNode da = new Solution().MiddleNode(d);
        }
    }
}