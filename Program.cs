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

            ll.PrintList();
            
            ll.InsertAtFront(88);
            ll.PrintList();

            ll.InsertAfterNode(ll.head.next.next, 43);
            ll.PrintList();
            ll.Size();

            ll.PrintRecursive(ll.head);
        }
    }
}
