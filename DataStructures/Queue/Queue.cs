using System;

namespace InterviewPrep
{

    class Queue<T> : IQueue<T>
    {

        // A queue is a data structure where the first element in the list is the first one to be deleted.
        // It follows FIFO.
        QueueNode<T> first;
        QueueNode<T> last;

        public void Add(T data)
        {
            var new_node = new QueueNode<T>(data);

            if (last != null) last.next = new_node;

            last = new_node;

            if (first == null) first = last;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public T Peek()
        {
            if (first == null) throw new NullReferenceException("Queue is null");
            return first.data;
        }

        public T Remove()
        {
            if (first == null) throw new NullReferenceException("Queue is null");

            T data = first.data;
            first = first.next;

            if (first == null) last = null;

            return data;
        }

        public void PrintQueue()
        {
            var temp = this.first;
            var count = 0;

            while (temp != null)
            {
                var printMessage = count > 0 ? " <== " : "";
                Console.Write($"{printMessage}{temp.data}");
                temp = temp.next;
                count++;
            }
        }
    }


}