namespace _876._Middle_of_the_Linked_List;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode Create(int[] nums)
    {
        ListNode node = new ListNode(nums[0]);
        ListNode current = node;

        for (int i = 1; i < nums.Length; i++)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;
        }
        return node;
    }

    public void ShowNodes()
    {
        ListNode n = this;

        while (n != null)
        {
            Console.WriteLine(n.val);
            n = n.next;
        }
    }
}
