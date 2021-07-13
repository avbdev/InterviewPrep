using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ll = new LinkedList<int>();

            ll.InsertNodeAtEnd(5);
            ll.InsertNodeAtEnd(6);
            ll.InsertNodeAtEnd(7);
            ll.InsertNodeAtEnd(8);
            ll.InsertNodeAtEnd(9);

            // ll.PrintList();

            ll.InsertAtFront(88);
            // ll.PrintList();

            ll.InsertAfterNode(ll.head.next.next, 43);

            ll.Size();
            ll.PrintList();
            // ll.DeleteNode(88);
            // ll.DeleteNode(9);

            var temp = ll.head;
            ll.DeleteNodeRecursive(ll.head, 88);
            ll.Size();
            ll.PrintList();
            ll.DeleteNodeRecursive(ll.head, 9);
            ll.Size();
            ll.PrintList();
            ll.DeleteNodeRecursive(ll.head, 5);
            ll.Size();
            ll.PrintList();

            ll.DeleteNode(43);

            ll.Size();
            ll.PrintList();
            // ll.PrintRecursive(ll.head);
        }
    }
}
