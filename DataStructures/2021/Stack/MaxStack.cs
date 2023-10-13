using System;

namespace InterviewPrep
{
    public class MaxStackNode
    {
        public int data;
        public int max;

        public MaxStackNode(int data, int max)
        {
            this.data = data;
            this.max = max;
        }
    }

    public class MinStackNode
    {
        public int data;
        public int min;

        public MinStackNode(int data, int min)
        {
            this.data = data;
            this.min = min;
        }
    }

    public class MaxStack : Stack<MaxStackNode>
    {

        public void Push(int data)
        {
            base.Push(new MaxStackNode(data, Math.Max(data, Max())));
        }

        public int Max()
        {
            return this.IsEmpty() ? Int32.MinValue : Peek().max;
        }

    }

    public class MinStack : Stack<MinStackNode>
    {

        public void Push(int data)
        {
            base.Push(new MinStackNode(data, Math.Min(data, Min())));
        }

        public int Min()
        {
            return this.IsEmpty() ? Int32.MaxValue : Peek().min;
        }

    }
}