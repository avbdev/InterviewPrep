using System;
using System.Collections.Generic;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 9, 2, 1, 0, 6 };
            Console.WriteLine("Initial Arr");
            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();
            InsertionSort(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted Arr");
            foreach (int i in arr)
            {

                Console.Write($"{i},");
            }
            Console.WriteLine();
            // LinkedListMethods();
            // StackMethods();
            // QueueMethods();
            // LinkedListBuiltIn();
            // MaxStackImpl();
        }

        public static void InsertionSort(int[] arr)
        {

            for (int j = 1; j < arr.Length; j++)
            {
                Console.WriteLine($"j:{j}");
                int key = arr[j], i = j - 1;
                Console.WriteLine($"arr[j]:{arr[j]}, key:{key}, arr[i]:{arr[i]}");

                while (i >= 0 && arr[i] > key)
                {
                    Console.WriteLine($"arr[i+1]:{arr[i + 1]}");
                    arr[i + 1] = arr[i];
                    i--;

                }
                arr[i + 1] = key;
                Console.WriteLine($"After While arr[i+1]:{arr[i + 1]}");
            }

        }

        public static List<int> GetKthFrequent(int[] arr, int k)
        {

            var freqCounter = new Dictionary<int, int>();
            var counterOccurrencesDict = new Dictionary<int, List<int>>();

            // Insert values and its count to the dictionary
            foreach (int ele in arr)
            {
                if (freqCounter.ContainsKey(ele)) freqCounter[ele]++;
                else freqCounter[ele] = 1;
            }


            // Dict --> {frq: HashSet<inputOccurences>}
            // We need an ele which is kth largest freq.
            // {frq: [inputOccurences] }
            // {3 : {1,2}, 2: {4,5,6}, 8:{32}}

            foreach (var kvp in freqCounter)
            {
                // value = key[set] = actual freq.
                if (counterOccurrencesDict.ContainsKey(kvp.Value))
                    counterOccurrencesDict[kvp.Value].Add(kvp.Key);
                else
                {
                    counterOccurrencesDict[kvp.Value] = new List<int>();
                    counterOccurrencesDict[kvp.Value].Add(kvp.Key);
                }
            }

            var keys = new List<int>(counterOccurrencesDict.Keys).ToArray();

            Array.Sort(keys);

            /*
                coll = {
                    1:{}
                    2:{}
                    3:{}
                    4:{}
                }

                We need 2nd Largest ==> 3 ==> coll.Count  = 4, k = 2 => Count - k = 2
            */

            var selectedKey = keys[keys.Length - k + 1];
            // Sort the keys in the dictionary

            return counterOccurrencesDict[selectedKey];//.ToList();

        }


        static void LinkedListMethods()
        {


            var ll = new LinkedList<int>();

            ll.InsertNodeAtEnd(2);
            ll.InsertNodeAtEnd(9);
            ll.InsertNodeAtEnd(2);
            ll.InsertNodeAtEnd(4);
            ll.InsertNodeAtEnd(4);
            ll.InsertNodeAtEnd(8);
            // ll.InsertNodeAtEnd(2);
            // ll.InsertNodeAtEnd(2);
            // ll.InsertNodeAtEnd(2);
            // ll.InsertNodeAtEnd(2);
            // ll.InsertNodeAtEnd(2);
            // ll.InsertNodeAtEnd(2);


            // var sumPairexist = SumPairExists(null, 54);

            ll.PrintList();

            ll.RemoveDups(ll);
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
