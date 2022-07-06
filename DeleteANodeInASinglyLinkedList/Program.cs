using System;
using DeleteANodeInASinglyLinkedList.BusinessLogic;

namespace DeleteANodeInASinglyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logic list = new Logic();
            list.Push(9);
            list.Push(1);
            list.Push(5);
            list.Push(4);

            Console.WriteLine("Linked list before deletion: ");
            list.printList();

            list.deleteNode(1);

            Console.WriteLine("Linked list after deletion: ");
            list.printList();
        }
       
    }

}
