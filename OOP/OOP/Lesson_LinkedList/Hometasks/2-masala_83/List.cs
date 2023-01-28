namespace OOP.Lesson_LinkedList.Hometasks
{
    internal class List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            else
            {
                ListNode list_n = head;

                while (list_n.next != null)
                {
                    if (list_n.val == list_n.next.val)
                    {
                        list_n.next = list_n.next.next;
                    }

                    else
                    {
                        list_n = list_n.next;
                    }
                }
            }

            return head;

        }
    }
}
