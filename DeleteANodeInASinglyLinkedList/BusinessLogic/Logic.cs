using System;

namespace DeleteANodeInASinglyLinkedList.BusinessLogic
{
    public class Logic
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        Node head;
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void deleteNode(int key)
        {
            Node node = head, prev = null;

            if (node != null && node.data == key)
            {
                head = node.next;
                return;
            }

            while (node != null && node.data != key)
            {
                prev = node;
                node = node.next;
            }

            if (node == null)
                return;

            prev.next = node.next;
        }
        public void printList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine("\n");
        }

    }
}
