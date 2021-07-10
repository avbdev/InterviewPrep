using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ll = new LinkedList<int>();

            ll.InsertNode(5);
            ll.InsertNode(6);
            ll.InsertNode(7);
            ll.InsertNode(8);
            ll.InsertNode(9);

            ll.PrintList();

        }
    }
}
