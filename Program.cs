using System;
using System.Collections.Generic;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedListMethods();
            // StackMethods();
            // QueueMethods();
            // LinkedListBuiltIn();
            MaxStackImpl();
        }

        static void LinkedListMethods()
        {

            var ll = new LinkedList<int>();

            ll.InsertNodeAtEnd(5);
            ll.InsertNodeAtEnd(6);
            ll.InsertNodeAtEnd(7);
            ll.InsertNodeAtEnd(8);
            ll.InsertNodeAtEnd(9);

            var sumPairexist = SumPairExists(null, 54);

            ll.PrintList();

            // ll.InsertAtFront(88);
            // // ll.PrintList();

            // ll.InsertAfterNode(ll.head.next.next, 43);

            // ll.Size();
            // ll.PrintList();
            // // ll.DeleteNode(88);
            // // ll.DeleteNode(9);

            // var temp = ll.head;
            // ll.DeleteNodeRecursive(ll.head, 88);
            // ll.Size();
            // ll.PrintList();
            // ll.DeleteNodeRecursive(ll.head, 9);
            // ll.Size();
            // ll.PrintList();
            // ll.DeleteNodeRecursive(ll.head, 5);
            // ll.Size();
            // ll.PrintList();

            // ll.DeleteNode(43);

            // ll.Size();
            // ll.PrintList();
            // ll.PrintRecursive(ll.head);
        }

        static void StackMethods()
        {
            var st = new Stack<int>();

            st.Push(5);
            st.Push(6);
            st.Push(7);
            st.Push(8);
            st.Push(9);

            st.PrintStack();
            var pops = st.Pop();

            Console.WriteLine($"Popped : {pops}");
            Console.WriteLine("Printing updated stack");
            st.PrintStack();

        }

        static void QueueMethods()
        {

            var qu = new Queue<string>();

            qu.Add("B");
            qu.Add("H");
            qu.Add("A");
            qu.Add("R");
            qu.Add("D");
            qu.Add("W");
            qu.Add("A");
            qu.Add("J");

            qu.PrintQueue();

            qu.Remove();
            qu.Remove();
            qu.Remove();
            var peek = qu.Peek();
            Console.WriteLine("");
            Console.WriteLine($"Peek {peek}");
            Console.WriteLine("Printing updated queue");

            qu.PrintQueue();
            qu.Remove();
            qu.Remove();
            qu.Remove();
            qu.Remove();
            // qu.Remove();

            Console.WriteLine("");
            Console.WriteLine("Printing updated queue");

            qu.PrintQueue();
        }

        static void LinkedListBuiltIn()
        {
            var ll = new System.Collections.Generic.LinkedList<int>();
            var llNode = new System.Collections.Generic.LinkedListNode<int>(5);
            ll.AddLast(5);
            ll.AddLast(6);
            ll.AddLast(7);
            ll.AddLast(8);

            var s = ll.ToString();
            foreach (var p in ll)
            {
                Console.WriteLine($"LL: {p}");
            }

        }

        static bool SumPairExists(LinkedList<int> list, int sum)
        {

            if (list == null) return false;

            var current = list.head;
            var nodeValues = new List<int>();

            while (current != null)
            {

                if (nodeValues.Contains(sum - current.data))
                {
                    return true;
                }
                else
                {
                    nodeValues.Add(current.data);
                    current = current.next;
                }
            }

            return false;
        }

        static void MaxStackImpl()
        {
            var ms = new MaxStack();
            // MaxStackNode a = new MaxStackNode
            ms.Push(-1);
            ms.Push(-100);
            ms.Push(-14);
            ms.Push(1);
            ms.Push(0);
            ms.Push(-411);
            ms.Push(4);

            int max = ms.Max();
            ms.Pop();
            max = ms.Max();

            var mn = new MinStack();
            mn.Push(-1);
            mn.Push(-100);
            mn.Push(-14);
            mn.Push(1);
            mn.Push(0);
            mn.Push(-411);
            mn.Push(4);
            int min = mn.Min();
            mn.Pop();
            mn.Pop();
            min = mn.Min();
        }

    }
}
