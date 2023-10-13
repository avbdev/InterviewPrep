using System;

namespace InterviewPrep
{

    public class Stack<T> : IStack<T>
    {
        // What is stack?

        // Stack is a data structure where the first element inserted 
        // will be the last one to come out. For example stack of plates.

        // How is this implemented ?

        // Push --> Inserts a new element
        // Pop --> Removes the the top element
        // Peek --> Return the top element
        // IsEmpty --> Returns true if empty

        // The idea is that the top always points to the most recent element.

        private StackNode<T> top;

        public bool IsEmpty()
        {
            return top == null;
        }

        public T Peek()
        {
            return this.top.data;
        }

        public T Pop()
        {
            if (top == null) throw new NullReferenceException("Stack is empty");

            T removedItem = top.data;
            top = top.next;

            return removedItem;
        }

        public void Push(T data)
        {
            var new_node = new StackNode<T>(data);

            new_node.next = top;
            top = new_node;
        }

        public void PrintStack()
        {
            var temp = this.top;
            var count = 0;

            while (temp != null)
            {
                var printMessage = count == 0 ? " --> top" : "";
                Console.WriteLine($"|  {temp.data}  |{printMessage}");
                Console.WriteLine(" ----- ");

                temp = temp.next;
                count++;
            }
        }
    }
}