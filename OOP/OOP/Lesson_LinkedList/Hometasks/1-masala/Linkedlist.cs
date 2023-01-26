namespace OOP.Lesson_LinkedList.Hometasks._1_masala
{
    internal class Linkedlist
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

        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                ListNode temp = head;
                int count1 = 0;
                int count2 = 0;

                while (temp != null)
                {
                    temp = temp.next;
                    count1++;
                }
                temp = head;
                while (temp != null)
                {
                    count2++;
                    if (count1 % 2 == 0 && count2 > count1 / 2)
                    {
                        return temp;
                    }

                    else if (count1 % 2 != 0 && count2 - 1 >= count1 / 2)
                    {
                        return temp;
                    }
                    else temp = temp.next;
                }

                return temp;
            }
        }
    }
}
