using System;
namespace Atcoder
{
    //https://www.youtube.com/watch?v=0AO7OwNzd2Y

    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    class LinkedList
    {
        int count;
        LinkedListNode head;

        public LinkedList()
        {
            head = null;
            count++;
        }

        public void AddNodeToFrony(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }
}



