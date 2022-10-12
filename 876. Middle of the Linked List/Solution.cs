namespace _876._Middle_of_the_Linked_List;

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int len = 0;
        ListNode temp = head;

        while (head != null)
        {
            head = head.next;
            len++;
        }
        head = temp;

        for (int i = 0; i <= (len / 2) - 1; i++)
        {
            head = head.next;
        }

        return head;
    }
}
