namespace InterviewPrep
{
    interface IQueue<T>
    {
        void Add(T data);
        T Remove();
        T Peek();
        bool IsEmpty();
    }
}